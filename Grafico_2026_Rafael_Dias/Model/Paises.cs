using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Model
{
    internal class Paises : Pai
    {
        protected string pais;
        protected string sigla;
        protected string ddi;
        protected string moeda;

        public Paises() : base()
        {
            pais = string.Empty;
            sigla = string.Empty;
            ddi = string.Empty;
            moeda = string.Empty;
        }

        public Paises(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao, string pais, string sigla, string ddi, string moeda) : base(codigo, codigoUsuario, dataCadastro, dataAlteracao)
        {
            this.pais = pais;
            this.sigla = sigla;
            this.ddi = ddi;
            this.moeda = moeda;
        }

        public Paises Clone()
        {
            return new Paises(codigo, codigoUsuario, dataCadastro, dataAlteracao, pais, sigla, ddi, moeda);
        }

        public string Pais
        {
            get => pais;
            set => pais = value;
        }

        public string Sigla
        {
            get => sigla;
            set => sigla = value;
        }

        public string DDI
        {
            get => ddi;
            set => ddi = value;
        }

        public string Moeda
        {
            get => moeda;
            set => moeda = value;
        }
    }
}
