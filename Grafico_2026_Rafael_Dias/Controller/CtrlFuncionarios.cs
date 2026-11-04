using Grafico_2026_Rafael_Dias.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias.Controller
{
    internal class CtrlFuncionarios : Controller
    {
        protected CtrlCargos oCtrlCargos;
        protected CtrlCidades oCtrlCidades;
        protected DaoFuncionarios oDaoFuncionarios;

        public CtrlFuncionarios()
        {
            oCtrlCargos = new CtrlCargos();
            oCtrlCidades = new CtrlCidades();
            oDaoFuncionarios = new DaoFuncionarios();
        }
        public override string Salvar(object obj)
        {
            return oDaoFuncionarios.Salvar(obj);
        }

        public override string CarregarObj(object obj)
        {
            return oDaoFuncionarios.CarregarObj(obj);
        }

        public override List<object> CarregarColecao(object obj)
        {
            return oDaoFuncionarios.CarregarColecao(obj);
        }

        public override List<object> Pesquisar(object obj)
        {
            return oDaoFuncionarios.Pesquisar(obj);
        }

        public override string Excluir(object obj)
        {
            return oDaoFuncionarios.Excluir(obj);
        }

        public CtrlCargos OCtrlCargos
        {
            get => oCtrlCargos;
            set => oCtrlCargos = value;
        }

        public CtrlCidades OCtrlCidades
        {
            get => oCtrlCidades;
            set => oCtrlCidades = value;
        }

        public DaoFuncionarios ODaoFuncionarios
        {
            get => oDaoFuncionarios;
            set => oDaoFuncionarios = value;
        }
    }
}
