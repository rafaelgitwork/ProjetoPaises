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
        internal class DaoEstados : Dao
        {
            protected SqlConnection cnn;
            public DaoEstados()
            {
                cnn = Banco.AbrirBD();
            }

            public override string CarregarObj(object obj)
            {
                Estados oEstado = (Estados)obj;
                string sql = "SELECT ID_Estados, Estado, UF, ID_Pais FROM Estados WHERE ID_Estados = @codigo";
                try
                {
                    using (SqlConnection cnn = Banco.AbrirBD())
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                                return "Codigo do Estado não encontrado.";
                            oEstado.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Estados"));
                            oEstado.Estado = dr.GetString(dr.GetOrdinal("Estado"));
                            oEstado.UF = dr.GetString(dr.GetOrdinal("UF"));
                            oEstado.OPais.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Pais"));
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
                Estados oEstado = (Estados)obj;
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlTransaction tx = cnn.BeginTransaction())
                {
                    try
                    {
                        int codigo;

                        if (oEstado.Codigo == 0)
                        {
                            const string sql = "insert into Estados(Estado, UF, ID_Pais) " +
                                               "output inserted.ID_Estados " +
                                               "values (@estado, @uf, @idPais)";
                            using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                            {
                                AdicionarParametro(cmd, oEstado);
                                codigo = (int)cmd.ExecuteScalar();
                            }
                        }
                        else
                        {
                            const string sql = "update Estados set Estado = @estado, UF = @uf, ID_Pais = @idPais, " +
                                               "DataAlteracao = GETDATE() where ID_Estados = @codigo";
                            using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                            {
                                AdicionarParametro(cmd, oEstado);
                                cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;
                                if (cmd.ExecuteNonQuery() == 0)
                                    throw new InvalidOperationException("Nenhum registro foi atualizado.");
                            }
                            codigo = oEstado.Codigo;
                        }
                        tx.Commit();
                        oEstado.Codigo = codigo;
                        return codigo.ToString();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }

            private static void AdicionarParametro(SqlCommand cmd, Estados oEstado)
            {
                cmd.Parameters.Add("@estado", SqlDbType.VarChar, 55).Value = oEstado.Estado;
                cmd.Parameters.Add("@uf", SqlDbType.VarChar, 3).Value = oEstado.UF;
                cmd.Parameters.Add("@idPais", SqlDbType.Int).Value = oEstado.OPais.Codigo;
            }

            public override List<object> Pesquisar(object obj)
            {
                Estados oEstado = (Estados)obj;
                string sql = "SELECT E.ID_Estados, E.Estado, E.UF, E.ID_Pais, P.Pais FROM Estados E inner join Paises P on E.ID_Pais = P.ID_Paises";
                var Lista = new List<object>();
                using (var cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@chave", "%" + oEstado.Estado + "%");
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Estados estado = new Estados();
                            estado.Codigo = Convert.ToInt32(dr["ID_Estados"]);
                            estado.Estado = dr["Estado"].ToString();
                            estado.UF = dr["UF"].ToString();
                            estado.OPais.Codigo = Convert.ToInt32(dr["ID_Pais"]);
                            estado.OPais.Pais = dr["Pais"].ToString();
                            Lista.Add(estado);
                        }
                    }
                }
                return Lista;
            }

            public override string Excluir(object obj)
            {
                Estados oEstado = (Estados)obj;
                string sql = "delete from Estados where ID_Estados = @codigo";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                    cmd.ExecuteNonQuery();
                }
                return string.Empty;
            }
        }
    }
