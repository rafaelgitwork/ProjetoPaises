using Grafico_2026_Rafael_Dias.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Controller
{
    internal class CtrlPaises: Controller
    {
        protected DaoPaises oDaoPaises;
        public CtrlPaises()
        {
            oDaoPaises = new DaoPaises();
        }

        public override string Salvar(object obj)
        {
            return oDaoPaises.Salvar(obj);
        }

        public override List<object> Pesquisar(object obj)
        {
            return oDaoPaises.Pesquisar(obj);
        }

        public override List<object> CarregarColecao(object obj)
        {
            return oDaoPaises.CarregarColecao(obj);
        }

        public override string CarregarObj(object obj)
        {
            return oDaoPaises.CarregarObj(obj);
        }

        public override string Excluir(object obj)
        {
            return oDaoPaises.Excluir(obj);
        }

        public DaoPaises ODaoPaises
        {
            get => oDaoPaises;
            set => oDaoPaises = value;
        }
    }
}
