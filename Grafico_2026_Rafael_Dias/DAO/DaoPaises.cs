using Grafico_2026_Rafael_Dias.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.DAO
{
    internal class DaoPaises : Dao
    {
        protected SqlConnection cnn;
        public DaoPaises()
        {
            cnn = Banco.AbrirBD();
        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oPais.Codigo == 0)
                    {
                        const string sql = "insert into Paises(Pais, Sigla, DDI , Moeda) " +
                                            "output inserted.ID_Paises " +
                                           "values (@pais, @sigla, @ddi, @moeda)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oPais);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql = "update Paises set Pais = @pais, Sigla = @sigla, DDI = @ddi, Moeda = @moeda " +
                            "where ID_Paises = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oPais);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                        }
                        codigo = oPais.Codigo;
                    }
                    tx.Commit();
                    oPais.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }
        private static void AdicionarParametro(SqlCommand cmd, Paises oPais)
        {
            cmd.Parameters.Add("@pais", SqlDbType.VarChar, 100).Value = oPais.Pais;
            cmd.Parameters.Add("@sigla", SqlDbType.VarChar, 10).Value = oPais.Sigla;
            cmd.Parameters.Add("@ddi", SqlDbType.VarChar, 10).Value = oPais.DDI;
            cmd.Parameters.Add("@moeda", SqlDbType.VarChar, 50).Value = oPais.Moeda;
        }

        public override string CarregarObj(object obj)
        {
            Paises oPais = (Paises)obj;

            string sql = "SELECT ID_Paises, Pais, Sigla, DDI, Moeda FROM Paises WHERE ID_Paises = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo do Pais não encontrado.";
                        oPais.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Paises"));
                        oPais.Pais = dr.GetString(dr.GetOrdinal("Pais"));
                        oPais.Sigla = dr["Sigla"].ToString();
                        oPais.DDI = dr["DDI"].ToString();
                        oPais.Moeda = dr["Moeda"].ToString();
                    }
                }
                return "";
            }
            catch (SqlException ex)
            {
                return "Erro do banco de Dados: " + ex.Message;
            }
        }

        public override List<object> CarregarColecao(object obj)
        {
            return null;
        }

        public override List<object> Pesquisar(object obj)
        {
            Paises oPais = (Paises)obj;
            string sql = "SELECT ID_Paises, Pais, Sigla, DDI, Moeda FROM Paises WHERE Pais  LIKE @chave";
            var Lista = new List<object>();
            using (var cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@chave", "%" + oPais.Pais + "%");
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Paises pais = new Paises();
                        pais.Codigo = Convert.ToInt32(dr["ID_Paises"]);
                        pais.Pais = dr["Pais"].ToString();
                        pais.Sigla = dr["Sigla"].ToString();
                        pais.DDI = dr["DDI"].ToString();
                        pais.Moeda = dr["Moeda"].ToString();
                        Lista.Add(pais);
                    }
                }
            }
            return Lista;
        }


        public override string Excluir(object obj)
        {
            Paises oPais = (Paises)obj;
            string sql = "delete Paises where ID_Paises = @codigo";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
            }
            return string.Empty;
        }
    }
}