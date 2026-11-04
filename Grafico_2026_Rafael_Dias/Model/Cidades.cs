using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Model
{
    internal class Cidades : Pai
    {

        protected string cidade;
        protected string ddd;
        protected Estados oEstado;

        public Cidades():base(){
            cidade = string.Empty;
            ddd = string.Empty;
            oEstado = new Estados();
        }

        public Cidades(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao, string cidade, string ddd, Estados oEstado):base(codigo, codigoUsuario, dataCadastro, dataAlteracao)
        {
            this.cidade = cidade;
            this.ddd = ddd;
            this.oEstado = oEstado.Clone();
        }

        public Cidades Clone()
        {
            return new Cidades(codigo, codigoUsuario, dataCadastro, dataAlteracao, cidade, ddd, oEstado.Clone());
        }

        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }

        public string DDD
        {
            get => ddd;
            set => ddd = value;
        }
        public Estados OEstado 
        {  
            get => oEstado; 
            set => oEstado = value; 
        }

    }
}
