using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Model
{
    internal class Pessoa : Pai
    {
        protected string nome;
        protected int idade;
        protected char sexo;

        public Pessoa() : base()
        {
            nome = string.Empty;
            idade = 0;
            sexo = ' ';
        }
        public Pessoa(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao, string nome, int idade, char sexo) : base(codigo, codigoUsuario, dataCadastro, dataAlteracao)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        public Pessoa Clone()
        {
            return new Pessoa(codigo, codigoUsuario, dataCadastro, dataAlteracao, nome, idade, sexo);
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        public char Sexo
        {
            get => sexo;
            set => sexo = value;
        }

    }
}
