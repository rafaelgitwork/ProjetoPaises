using Grafico_2026_Rafael_Dias.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Controller
{
    internal class CtrlEstados : Controller
    {
        protected CtrlPaises oCtrlPaises;
        protected DaoEstados oDaoEstados;

        public CtrlEstados()
        {
            oCtrlPaises = new CtrlPaises();
            oDaoEstados = new DaoEstados();
        }

        public override string Salvar(object obj)
        {
            return oDaoEstados.Salvar(obj);
        }

        public override string CarregarObj(object obj)
        {
            return oDaoEstados.CarregarObj(obj);
        }

        public override List<object> CarregarColecao(object obj)
        {
            return oDaoEstados.CarregarColecao(obj);
        }

        public override List<object> Pesquisar(object obj)
        {
            return oDaoEstados.Pesquisar(obj);
        }

        public override string Excluir(object obj)
        {
            return oDaoEstados.Excluir(obj);
        }

        public CtrlPaises OCtrlPaises
        {
            get => oCtrlPaises;
            set => oCtrlPaises = value;
        }

        public DaoEstados ODaoEstados
        {
            get => oDaoEstados;
            set => oDaoEstados = value;
        }
    }
}
