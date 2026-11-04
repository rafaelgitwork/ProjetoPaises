using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Model
{
    internal class Cargos : Pai
    {

        protected string cargo;
        protected bool exigeCnh;
        protected bool ganhaComissao;

        public Cargos()
        {
            cargo = string.Empty;
            exigeCnh = false;
            ganhaComissao = false;
        }

        public Cargos(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao, string cargo, bool exigeCnh, bool ganhaComissao):base(codigo, codigoUsuario, dataCadastro, dataAlteracao)
        {
            this.cargo = cargo;
            this.exigeCnh = exigeCnh;
            this.ganhaComissao = ganhaComissao;
        }

        public Cargos Clone()
        {
            return new Cargos(codigo, codigoUsuario, dataCadastro, dataAlteracao, cargo, exigeCnh, ganhaComissao);
        }

        public string Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public bool ExigeCnh
        {
            get => exigeCnh;
            set => exigeCnh = value;
        }

        public bool GanhaComissao
        {
            get => ganhaComissao;
            set => ganhaComissao = value;
        }

    }
}
