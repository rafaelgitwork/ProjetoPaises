using Grafico_2026_Rafael_Dias.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Controller
{
    internal class CtrlCidades : Controller
    {
        protected CtrlEstados oCtrlEstados;
        protected DaoCidades oDaoCidades;

        public CtrlCidades()
        {
            oCtrlEstados = new CtrlEstados();
            oDaoCidades = new DaoCidades();
        }

        public override string Salvar(object obj)
        {
            return oDaoCidades.Salvar(obj);
        }

        public override string CarregarObj(object obj)
        {
            return oDaoCidades.CarregarObj(obj);
        }

        public override List<object> CarregarColecao(object obj)
        {
            return oDaoCidades.CarregarColecao(obj);
        }

        public override List<object> Pesquisar(object obj)
        {
            return oDaoCidades.Pesquisar(obj);
        }

        public override string Excluir(object obj)
        {
            return oDaoCidades.Excluir(obj);
        }

        public CtrlEstados OCtrlEstados
        {
            get => oCtrlEstados;
            set => oCtrlEstados = value;
        }

        public DaoCidades ODaoCidades
        {
            get => oDaoCidades;
            set => oDaoCidades = value;
        }
    }
}
