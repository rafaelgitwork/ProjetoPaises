using Grafico_2026_Rafael_Dias.View.Cadastro;
using Grafico_2026_Rafael_Dias.View.Consulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafico_2026_Rafael_Dias
{
    internal class Interfaces
    {
        protected FrmConPaises oFrmConPaises;
        protected FrmConEstados oFrmConEstados;
        protected FrmConCidades oFrmConCidades;
        protected FrmConCargos oFrmConCargos;
        protected FrmConFuncionarios oFrmConFuncionarios;

        protected FrmCadPaises oFrmCadPaises;
        protected FrmCadEstados oFrmCadEstados;
        protected FrmCadCidades oFrmCadCidades;
        protected FrmCadCargos oFrmCadCargos;
        protected FrmCadFuncionarios oFrmCadFuncionarios;  

        public Interfaces()
        {
            oFrmConPaises       = new FrmConPaises();
            oFrmConEstados      = new FrmConEstados();
            oFrmConCidades      = new FrmConCidades();
            oFrmConCargos       = new FrmConCargos();
            oFrmConFuncionarios = new FrmConFuncionarios();

            oFrmCadPaises       = new FrmCadPaises();
            oFrmCadEstados      = new FrmCadEstados();
            oFrmCadCidades      = new FrmCadCidades();
            oFrmCadCargos       = new FrmCadCargos();
            oFrmCadFuncionarios = new FrmCadFuncionarios();

            oFrmConPaises.SetFrmCadastro(oFrmCadPaises);
            oFrmConEstados.SetFrmCadastro(oFrmCadEstados);
            oFrmConCidades.SetFrmCadastro(oFrmCadCidades);
            oFrmConCargos.SetFrmCadastro(oFrmCadCargos);
            oFrmConFuncionarios.SetFrmCadastro(oFrmCadFuncionarios);

            oFrmCadEstados.SetFrmConsulta(oFrmConPaises);
            oFrmCadCidades.SetFrmConsulta(oFrmConEstados);
            oFrmCadFuncionarios.SetFrmConsulta(oFrmConCargos, oFrmConCidades);
        }

        public void PecaPaises(object obj, object ctrl)
        {
            oFrmConPaises.ConhecaObj(obj, ctrl);
            oFrmConPaises.ShowDialog();
        }

        public void PecaEstados(object obj, object ctrl)
        {
            oFrmConEstados.ConhecaObj(obj, ctrl);
            oFrmConEstados.ShowDialog();
        }

        public void PecaCidades(object obj, object ctrl)
        {
            oFrmConCidades.ConhecaObj(obj, ctrl);
            oFrmConCidades.ShowDialog();
        }

        public void PecaCargos(object obj, object ctrl)
        {
            oFrmConCargos.ConhecaObj(obj, ctrl);
            oFrmConCargos.ShowDialog();
        }

        public void PecaFuncionarios(object obj, object ctrl)
        {
            oFrmConFuncionarios.ConhecaObj(obj, ctrl);
            oFrmConFuncionarios.ShowDialog();
        }
    }
}
