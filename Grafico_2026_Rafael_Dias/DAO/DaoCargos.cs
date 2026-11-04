using Grafico_2026_Rafael_Dias.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Grafico_2026_Rafael_Dias.DAO
{
    internal class DaoCargos : Dao
    {
        protected SqlConnection cnn;
        public DaoCargos()
        {
            cnn = Banco.AbrirBD();
        }

        public override string CarregarObj(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string sql = "SELECT ID_Cargos, Cargo, Exige_CNH, Ganha_Comissao FROM Cargos WHERE ID_Cargos = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo do Cargo não encontrado.";
                        oCargo.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Cargos"));
                        oCargo.Cargo = dr["Cargo"].ToString();
                        oCargo.ExigeCnh = dr["Exige_CNH"] != DBNull.Value && Convert.ToBoolean(dr["Exige_CNH"]);
                        oCargo.GanhaComissao = dr["Ganha_Comissao"] != DBNull.Value && Convert.ToBoolean(dr["Ganha_Comissao"]);
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
            Cargos oCargo = (Cargos)obj;
            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oCargo.Codigo == 0)
                    {
                        const string sql = "insert into Cargos(Cargo, Exige_CNH, Ganha_Comissao) " +
                                           "output inserted.ID_Cargos " +
                                           "values (@cargo, @exigeCnh, @ganhaComissao)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oCargo);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql = "update Cargos set Cargo = @cargo, Exige_CNH = @exigeCnh, Ganha_Comissao = @ganhaComissao, " +
                                           "DataAlteracao = GETDATE() where ID_Cargos = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oCargo);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                        }
                        codigo = oCargo.Codigo;
                    }
                    tx.Commit();
                    oCargo.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametro(SqlCommand cmd, Cargos oCargo)
        {
            cmd.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = oCargo.Cargo;
            cmd.Parameters.Add("@exigeCnh", SqlDbType.Bit).Value = oCargo.ExigeCnh;
            cmd.Parameters.Add("@ganhaComissao", SqlDbType.Bit).Value = oCargo.GanhaComissao;
        }

        public override List<object> Pesquisar(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string sql = "SELECT ID_Cargos, Cargo, Exige_CNH, Ganha_Comissao FROM Cargos";
            var Lista = new List<object>();
            using (var cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@chave", "%" + oCargo.Cargo + "%");
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cargos cargo = new Cargos();
                        cargo.Codigo = Convert.ToInt32(dr["ID_Cargos"]);
                        cargo.Cargo = dr["Cargo"].ToString();
                        cargo.ExigeCnh = dr["Exige_CNH"] != DBNull.Value && Convert.ToBoolean(dr["Exige_CNH"]);
                        cargo.GanhaComissao = dr["Ganha_Comissao"] != DBNull.Value && Convert.ToBoolean(dr["Ganha_Comissao"]);
                        Lista.Add(cargo);
                    }
                }
            }
            return Lista;
        }

        public override string Excluir(object obj)
        {
            Cargos oCargo = (Cargos)obj;
            string sql = "delete from Cargos where ID_Cargos = @codigo";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oCargo.Codigo);
                cmd.ExecuteNonQuery();
            }
            return string.Empty;
        }
    }
}