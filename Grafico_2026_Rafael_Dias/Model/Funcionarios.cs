using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Grafico_2026_Rafael_Dias.Model
{
    internal class Funcionarios : Pessoa
    {
        protected string matricula;
        protected string cpf;
        protected Cargos oCargo;
        protected double salBase;
        protected double gratificacao;
        protected int numDep;
        protected string cep;
        protected string logradouro;
        protected int numero;
        protected string complemento;
        protected string bairro;
        protected Cidades oCidade;
        protected string cnh;
        protected string dataValidadeCnh;
        protected char tipoCnh;

        public Funcionarios():base()
        {
            matricula = string.Empty;
            cpf = string.Empty;
            oCargo = new Cargos();
            salBase = 0.0;
            gratificacao = 0.0;
            numDep = 0;
            cep = string.Empty;
            logradouro = string.Empty;
            numero = 0;
            complemento = string.Empty;
            bairro = string.Empty;
            oCidade = new Cidades();
            cnh = string.Empty;
            tipoCnh = ' ';
            dataValidadeCnh = Convert.ToString(DateTime.Now);
        }

        public Funcionarios(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao, string nome, int idade, char sexo, string matricula, string cpf, Cargos oCargo, double salBase, double gratificacao, int numDep, string cep, string logradouro, int numero, string complemento, string bairro, Cidades oCidade, string cnh, string dataValidadeCnh, char tipoCnh):base(codigo, codigoUsuario, dataCadastro, dataAlteracao, nome, idade, sexo)
        {
            this.matricula = matricula;
            this.cpf = cpf;
            this.oCargo = OCargo.Clone();
            this.salBase = salBase;
            this.gratificacao = gratificacao;
            this.numDep = numDep;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.oCidade = oCidade.Clone();
            this.cnh = cnh;
            this.dataValidadeCnh = dataValidadeCnh;
            this.tipoCnh = tipoCnh;
        }

        public Funcionarios Clone()
        {
            return new Funcionarios(codigo, codigoUsuario, dataCadastro, dataAlteracao, nome, idade, sexo, matricula, cpf, oCargo, salBase, gratificacao, numDep, cep, logradouro, numero, complemento, bairro, oCidade, cnh, dataValidadeCnh, tipoCnh);
        }

        public virtual double CalcSalBr()
        {
            return salBase + gratificacao;
        }

        public virtual double CalcAuxDep()
        {
            double auxDep;
            if (numDep <= 4)
            {
                auxDep = numDep * 50.00;
            }
            else
                auxDep = 200.00;
            return auxDep;
        }

        public virtual double CalcInss()
        {
            return this.CalcSalBr() * 0.10;
        }

        public virtual double CalcIr()
        {
            double ir = 0, salBruto = this.CalcSalBr();
            if (salBruto < 2428.00)
            {
                ir = 0;
            }
            else if (salBruto <= 2826.65)
            {
                ir = salBruto * 0.075 - 182.16;
            }
            else if (salBruto <= 3751.05)
            {
                ir = salBruto * 0.15 - 394.16;
            }
            else if (salBruto <= 4664.68)
            {
                ir = salBruto * 0.225 - 675.49;
            }
            else
            {
                ir = salBruto * 0.275 - 908.73;
            }
            return ir;
        }

        public virtual double CalcSaliq()
        {
            return this.CalcSalBr() + this.CalcAuxDep() - this.CalcInss() - this.CalcIr();
        }

        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }

        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }

        public Cargos OCargo
        {
            get => oCargo;
            set => oCargo = value;
        }

        public double SalBase
        {
            get => salBase;
            set => salBase = value;
        }

        public double Gratificacao
        {
            get => gratificacao;
            set => gratificacao = value;
        }

        public int NumDep
        {
            get => numDep;
            set => numDep = value;
        }

        public string Cep
        {
            get => cep;
            set => cep = value;
        }

        public string Logradouro
        {
            get => logradouro;
            set => logradouro = value;
        }

        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public string Complemento
        {
            get => complemento;
            set => complemento = value;
        }

        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }

        public Cidades OCidade
        {
            get => oCidade;
            set => oCidade = value;
        }

        public string Cnh
        {
            get => cnh;
            set => cnh = value;
        }

        public string DataValidadeCnh
        {
            get => dataValidadeCnh;
            set => dataValidadeCnh = value;
        }

        public char TipoCnh
        {
            get => tipoCnh;
            set => tipoCnh = value;
        }

    }
}
