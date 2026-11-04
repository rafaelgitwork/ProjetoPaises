using Grafico_2026_Rafael_Dias.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Controller
{
    internal class CtrlCargos : Controller
    {
        protected DaoCargos oDaoCargos;

        public CtrlCargos()
        {
            oDaoCargos = new DaoCargos();
        }

        public override string Salvar(object obj)
        {
            return oDaoCargos.Salvar(obj);
        }

        public override string CarregarObj(object obj)
        {
            return oDaoCargos.CarregarObj(obj);
        }

        public override List<object> CarregarColecao(object obj)
        {
            return oDaoCargos.CarregarColecao(obj);
        }

        public override List<object> Pesquisar(object obj)
        {
            return oDaoCargos.Pesquisar(obj);
        }

        public override string Excluir(object obj)
        {
            return oDaoCargos.Excluir(obj);
        }

        public DaoCargos ODaoCargos
        {
            get => oDaoCargos;
            set => oDaoCargos = value;
        }
    }
}
