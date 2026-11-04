using Grafico_2026_Rafael_Dias.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Grafico_2026_Rafael_Dias.DAO
{
    internal class DaoCidades : Dao
    {
        protected SqlConnection cnn;
        public DaoCidades()
        {
            cnn = Banco.AbrirBD();
        }

        public override string CarregarObj(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string sql = "SELECT C.ID_Cidades, C.Cidade, C.DDD, C.ID_Estado, E.Estado " +
                         "FROM Cidades C INNER JOIN Estados E ON C.ID_Estado = E.ID_Estados " +
                         "WHERE C.ID_Cidades = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo da Cidade não encontrado.";
                        oCidade.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Cidades"));
                        oCidade.Cidade = dr.GetString(dr.GetOrdinal("Cidade"));
                        oCidade.DDD = dr["DDD"].ToString();
                        oCidade.OEstado.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Estado"));
                        oCidade.OEstado.Estado = dr.GetString(dr.GetOrdinal("Estado"));
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

        public override string Salvar(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oCidade.Codigo == 0)
                    {
                        const string sql = "insert into Cidades(Cidade, DDD, ID_Estado) " +
                                           "output inserted.ID_Cidades " +
                                           "values (@cidade, @ddd, @idEstado)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oCidade);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql = "update Cidades set Cidade = @cidade, DDD = @ddd, ID_Estado = @idEstado, " +
                                           "DataAlteracao = GETDATE() where ID_Cidades = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oCidade);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                                throw new Exception("Nenhum registro foi atualizado.");
                        }
                        codigo = oCidade.Codigo;
                    }
                    tx.Commit();
                    oCidade.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametro(SqlCommand cmd, Cidades oCidade)
        {
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar, 55).Value = oCidade.Cidade;
            cmd.Parameters.Add("@ddd", SqlDbType.VarChar, 3).Value = oCidade.DDD;
            cmd.Parameters.Add("@idEstado", SqlDbType.Int).Value = oCidade.OEstado.Codigo;
        }

        public override List<object> Pesquisar(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string sql = "SELECT C.ID_Cidades, C.Cidade, C.DDD, C.ID_Estado, E.Estado " +
                         "FROM Cidades C INNER JOIN Estados E ON C.ID_Estado = E.ID_Estados " +
                         "WHERE C.Cidade LIKE @chave";
            var Lista = new List<object>();
            using (var cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@chave", "%" + oCidade.Cidade + "%");
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cidades cidade = new Cidades();
                        cidade.Codigo = Convert.ToInt32(dr["ID_Cidades"]);
                        cidade.Cidade = dr["Cidade"].ToString();
                        cidade.DDD = dr["DDD"].ToString();
                        cidade.OEstado.Codigo = Convert.ToInt32(dr["ID_Estado"]);
                        cidade.OEstado.Estado = dr["Estado"].ToString();
                        Lista.Add(cidade);
                    }
                }
            }
            return Lista;
        }

        public override string Excluir(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            string sql = "delete from Cidades where ID_Cidades = @codigo";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oCidade.Codigo);
                cmd.ExecuteNonQuery();
            }
            return string.Empty;
        }
    }
}