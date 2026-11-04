using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Model
{
    internal class Pai
    {
        protected int codigo;
        protected int codigoUsuario;
        protected DateTime dataCadastro;
        protected DateTime dataAlteracao;

        public Pai()
        {
            codigo = 0;
            codigoUsuario = 0;
            dataCadastro = DateTime.Now;
            dataAlteracao = DateTime.Now;
        }

        public Pai(int codigo, int codigoUsuario, DateTime dataCadastro, DateTime dataAlteracao)
        {
            this.codigo = codigo;
            this.codigoUsuario = codigoUsuario;
            this.dataCadastro = dataCadastro;
            this.dataAlteracao = dataAlteracao;
        }

        public Pai Clone()
        {
            return new Pai(codigo, codigoUsuario, dataCadastro, dataAlteracao);

        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public int CodigoUsuario
        {
            get => codigoUsuario;
            set => codigoUsuario = value;
        }

        public DateTime DataCadastro
        {
            get => dataCadastro;
            set => dataCadastro = value;
        }

        public DateTime DataAlteracao
        {
            get => dataAlteracao;
            set => dataAlteracao = value;
        }

    }
    }
