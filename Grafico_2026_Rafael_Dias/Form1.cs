using Grafico_2026_Rafael_Dias.Controller;
using Grafico_2026_Rafael_Dias.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico_2026_Rafael_Dias
{
    public partial class FrmPrincipal : Form
    {

        private Interfaces aInter;
        private Paises oPais;
        private Estados oEstado;
        private Cidades oCidade;
        private Cargos oCargo;
        private Funcionarios oFuncionario;
        private CtrlPaises oCtrlPaises;
        private CtrlEstados oCtrlEstados;
        private CtrlCidades oCtrlCidades;
        private CtrlCargos oCtrlCargos;
        private CtrlFuncionarios oCtrlFuncionarios;

        public FrmPrincipal()
        {
            InitializeComponent();
            aInter = new Interfaces();
            oPais = new Paises();
            oEstado = new Estados();
            oCidade = new Cidades();
            oCargo = new Cargos();
            oFuncionario = new Funcionarios();
            oCtrlPaises = new CtrlPaises();
            oCtrlEstados = new CtrlEstados();
            oCtrlCidades = new CtrlCidades();
            oCtrlCargos = new CtrlCargos();
            oCtrlFuncionarios = new CtrlFuncionarios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais, oCtrlPaises);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, oCtrlEstados);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(oCidade, oCtrlCidades);
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCargos(oCargo, oCtrlCargos);
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaFuncionarios(oFuncionario, oCtrlFuncionarios);
        }

    }
}
