using Grafico_2026_Rafael_Dias.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Grafico_2026_Rafael_Dias.DAO
{
    internal class DaoFuncionarios : Dao
    {
        protected SqlConnection cnn;
        public DaoFuncionarios()
        {
            cnn = Banco.AbrirBD();
        }

        public override string CarregarObj(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string sql = "SELECT ID_Funcionario, Nome, Idade, Sexo, Matricula, CPF, ID_Cargo, SalarioBase, Gratificacao, Numero_Dependentes, " +
                         "CEP, Logradouro, Numero, Complemento, Bairro, ID_Cidade, Numero_CNH, Data_Validade_CNH, Tipo_CNH " +
                         "FROM Funcionarios WHERE ID_Funcionario = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo do Funcionario não encontrado.";
                        oFuncionario.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Funcionario"));
                        oFuncionario.Nome = dr["Nome"].ToString();
                        oFuncionario.Idade = Convert.ToInt32(dr["Idade"]);
                        oFuncionario.Sexo = Convert.ToChar(dr["Sexo"]);
                        oFuncionario.Matricula = dr["Matricula"].ToString();
                        oFuncionario.Cpf = dr["CPF"].ToString();
                        oFuncionario.OCargo.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Cargo"));
                        oFuncionario.SalBase = Convert.ToDouble(dr["SalarioBase"]);
                        oFuncionario.Gratificacao = Convert.ToDouble(dr["Gratificacao"]);
                        oFuncionario.NumDep = Convert.ToInt32(dr["Numero_Dependentes"]);
                        oFuncionario.Cep = dr["CEP"].ToString();
                        oFuncionario.Logradouro = dr["Logradouro"].ToString();
                        int numero;
                        int.TryParse(dr["Numero"].ToString(), out numero);
                        oFuncionario.Numero = numero;
                        oFuncionario.Complemento = dr["Complemento"].ToString();
                        oFuncionario.Bairro = dr["Bairro"].ToString();
                        oFuncionario.OCidade.Codigo = dr.GetInt32(dr.GetOrdinal("ID_Cidade"));
                        oFuncionario.Cnh = dr["Numero_CNH"].ToString();
                        if (!dr.IsDBNull(dr.GetOrdinal("Data_Validade_CNH")))
                            oFuncionario.DataValidadeCnh = Convert.ToDateTime(dr["Data_Validade_CNH"]).ToString("dd/MM/yyyy");
                        if (!dr.IsDBNull(dr.GetOrdinal("Tipo_CNH")))
                            oFuncionario.TipoCnh = Convert.ToChar(dr["Tipo_CNH"]);
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
            Funcionarios oFuncionario = (Funcionarios)obj;
            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oFuncionario.Codigo == 0)
                    {
                        const string sql = "insert into Funcionarios(Nome, Idade, Sexo, Matricula, CPF, ID_Cargo, SalarioBase, Gratificacao, Numero_Dependentes, " +
                                           "CEP, Logradouro, Numero, Complemento, Bairro, ID_Cidade, Numero_CNH, Data_Validade_CNH, Tipo_CNH) " +
                                           "output inserted.ID_Funcionario " +
                                           "values (@nome, @idade, @sexo, @matricula, @cpf, @idCargo, @salBase, @gratificacao, @numDep, " +
                                           "@cep, @logradouro, @numero, @complemento, @bairro, @idCidade, @cnh, @dataValidadeCnh, @tipoCnh)";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oFuncionario);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql = "update Funcionarios set Nome = @nome, Idade = @idade, Sexo = @sexo, Matricula = @matricula, CPF = @cpf, " +
                                           "ID_Cargo = @idCargo, SalarioBase = @salBase, Gratificacao = @gratificacao, Numero_Dependentes = @numDep, " +
                                           "CEP = @cep, Logradouro = @logradouro, Numero = @numero, Complemento = @complemento, Bairro = @bairro, " +
                                           "ID_Cidade = @idCidade, Numero_CNH = @cnh, Data_Validade_CNH = @dataValidadeCnh, Tipo_CNH = @tipoCnh, " +
                                           "DataAlteracao = GETDATE() where ID_Funcionario = @codigo";
                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametro(cmd, oFuncionario);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;
                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Nenhum registro foi atualizado.");
                        }
                        codigo = oFuncionario.Codigo;
                    }
                    tx.Commit();
                    oFuncionario.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametro(SqlCommand cmd, Funcionarios oFuncionario)
        {
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 55).Value = oFuncionario.Nome;
            cmd.Parameters.Add("@idade", SqlDbType.Int).Value = oFuncionario.Idade;
            cmd.Parameters.Add("@sexo", SqlDbType.VarChar, 2).Value = oFuncionario.Sexo.ToString();
            cmd.Parameters.Add("@matricula", SqlDbType.VarChar, 55).Value = oFuncionario.Matricula;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar, 11).Value = oFuncionario.Cpf;
            cmd.Parameters.Add("@idCargo", SqlDbType.Int).Value = oFuncionario.OCargo.Codigo;
            cmd.Parameters.Add("@salBase", SqlDbType.Float).Value = oFuncionario.SalBase;
            cmd.Parameters.Add("@gratificacao", SqlDbType.Float).Value = oFuncionario.Gratificacao;
            cmd.Parameters.Add("@numDep", SqlDbType.Int).Value = oFuncionario.NumDep;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar, 55).Value = oFuncionario.Cep;
            cmd.Parameters.Add("@logradouro", SqlDbType.VarChar, 55).Value = oFuncionario.Logradouro;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar, 8).Value = oFuncionario.Numero.ToString();
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar, 55).Value = oFuncionario.Complemento;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar, 55).Value = oFuncionario.Bairro;
            cmd.Parameters.Add("@idCidade", SqlDbType.Int).Value = oFuncionario.OCidade.Codigo;
            cmd.Parameters.Add("@cnh", SqlDbType.VarChar, 11).Value = oFuncionario.Cnh;

            if (string.IsNullOrWhiteSpace(oFuncionario.DataValidadeCnh))
                cmd.Parameters.Add("@dataValidadeCnh", SqlDbType.Date).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@dataValidadeCnh", SqlDbType.Date).Value = Convert.ToDateTime(oFuncionario.DataValidadeCnh);

            if (oFuncionario.TipoCnh == ' ')
                cmd.Parameters.Add("@tipoCnh", SqlDbType.VarChar, 1).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@tipoCnh", SqlDbType.VarChar, 1).Value = oFuncionario.TipoCnh.ToString();
        }

        public override List<object> Pesquisar(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string sql = "SELECT F.ID_Funcionario, F.Nome, F.Idade, F.Sexo, F.Matricula, F.CPF, F.ID_Cargo, CA.Cargo, " +
                         "F.SalarioBase, F.Gratificacao, F.Numero_Dependentes, F.CEP, F.Logradouro, F.Numero, F.Complemento, F.Bairro, " +
                         "F.ID_Cidade, CI.Cidade, F.Numero_CNH, F.Data_Validade_CNH, F.Tipo_CNH " +
                         "FROM Funcionarios F " +
                         "inner join Cargos CA on F.ID_Cargo = CA.ID_Cargos " +
                         "inner join Cidades CI on F.ID_Cidade = CI.ID_Cidades";
            var Lista = new List<object>();
            using (var cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@chave", "%" + oFuncionario.Nome + "%");
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionarios f = new Funcionarios();
                        f.Codigo = Convert.ToInt32(dr["ID_Funcionario"]);
                        f.Nome = dr["Nome"].ToString();
                        f.Idade = Convert.ToInt32(dr["Idade"]);
                        f.Sexo = Convert.ToChar(dr["Sexo"]);
                        f.Matricula = dr["Matricula"].ToString();
                        f.Cpf = dr["CPF"].ToString();
                        f.OCargo.Codigo = Convert.ToInt32(dr["ID_Cargo"]);
                        f.OCargo.Cargo = dr["Cargo"].ToString();
                        f.SalBase = Convert.ToDouble(dr["SalarioBase"]);
                        f.Gratificacao = Convert.ToDouble(dr["Gratificacao"]);
                        f.NumDep = Convert.ToInt32(dr["Numero_Dependentes"]);
                        f.Cep = dr["CEP"].ToString();
                        f.Logradouro = dr["Logradouro"].ToString();
                        int numero;
                        int.TryParse(dr["Numero"].ToString(), out numero);
                        f.Numero = numero;
                        f.Complemento = dr["Complemento"].ToString();
                        f.Bairro = dr["Bairro"].ToString();
                        f.OCidade.Codigo = Convert.ToInt32(dr["ID_Cidade"]);
                        f.OCidade.Cidade = dr["Cidade"].ToString();
                        f.Cnh = dr["Numero_CNH"].ToString();
                        if (!dr.IsDBNull(dr.GetOrdinal("Data_Validade_CNH")))
                            f.DataValidadeCnh = Convert.ToDateTime(dr["Data_Validade_CNH"]).ToString("dd/MM/yyyy");
                        if (!dr.IsDBNull(dr.GetOrdinal("Tipo_CNH")))
                            f.TipoCnh = Convert.ToChar(dr["Tipo_CNH"]);
                        Lista.Add(f);
                    }
                }
            }
            return Lista;
        }

        public override string Excluir(object obj)
        {
            Funcionarios oFuncionario = (Funcionarios)obj;
            string sql = "delete from Funcionarios where ID_Funcionario = @codigo";
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@codigo", oFuncionario.Codigo);
                cmd.ExecuteNonQuery();
            }
            return string.Empty;
        }
    }
}