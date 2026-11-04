using Grafico_2026_Rafael_Dias.Controller;
using Grafico_2026_Rafael_Dias.Model;
using Grafico_2026_Rafael_Dias.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Rafael_Dias.View.Consulta
{
    public partial class FrmConFuncionarios : Grafico_2026_Rafael_Dias.View.FrmConsulta
    {
        private Funcionarios oFuncionario;
        private FrmCadFuncionarios oFrmCadFuncionarios;
        private CtrlFuncionarios oCtrlFuncionarios;
        public FrmConFuncionarios()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oFuncionario = (Funcionarios)obj;
            oCtrlFuncionarios = (CtrlFuncionarios)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadFuncionarios = (FrmCadFuncionarios)obj;
        }

        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Funcionarios oFuncionarioFiltro = new Funcionarios();
            oFuncionarioFiltro.Nome = txtCodigo.Text.Trim().ToUpper();
            var lista = oCtrlFuncionarios.Pesquisar(oFuncionarioFiltro);
            if (lista != null)
            {
                foreach (Funcionarios f in lista)
                    AdicionarLinhaLV(f);
            }
        }

        private void AdicionarLinhaLV(Funcionarios oFuncionarioA)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(oFuncionarioA.Codigo.ToString());
            item.SubItems.Add(oFuncionarioA.Nome);
            item.SubItems.Add(oFuncionarioA.Idade.ToString());
            item.SubItems.Add(oFuncionarioA.Sexo.ToString());
            item.SubItems.Add(oFuncionarioA.Matricula);
            item.SubItems.Add(oFuncionarioA.Cpf);
            item.SubItems.Add(oFuncionarioA.OCargo.Codigo.ToString());
            item.SubItems.Add(oFuncionarioA.OCargo.Cargo);
            item.SubItems.Add(oFuncionarioA.SalBase.ToString("N2"));
            item.SubItems.Add(oFuncionarioA.Gratificacao.ToString("N2"));
            item.SubItems.Add(oFuncionarioA.NumDep.ToString());
            item.SubItems.Add(oFuncionarioA.Cep);
            item.SubItems.Add(oFuncionarioA.Logradouro);
            item.SubItems.Add(oFuncionarioA.Numero.ToString());
            item.SubItems.Add(oFuncionarioA.Complemento);
            item.SubItems.Add(oFuncionarioA.Bairro);
            item.SubItems.Add(oFuncionarioA.OCidade.Codigo.ToString());
            item.SubItems.Add(oFuncionarioA.OCidade.Cidade);
            item.SubItems.Add(oFuncionarioA.Cnh);
            item.SubItems.Add(oFuncionarioA.DataValidadeCnh);
            item.SubItems.Add(oFuncionarioA.TipoCnh.ToString());
            item.Tag = oFuncionarioA;
            LV.Items.Add(item);
        }

        private Funcionarios FuncionarioSelecionado()
        {
            if (LV.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro na lista.");
                return null;
            }
            return (Funcionarios)LV.SelectedItems[0].Tag;
        }

        public override void Incluir()
        {
            oFrmCadFuncionarios.ConhecaObj(new Funcionarios(), oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
            Pesquisar();
        }

        public override void Alterar()
        {
            Funcionarios oSel = FuncionarioSelecionado();
            if (oSel == null) return;
            oFrmCadFuncionarios.ConhecaObj(oSel, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
            Pesquisar();
        }

        public override void Excluir()
        {
            Funcionarios oSel = FuncionarioSelecionado();
            if (oSel == null) return;
            string aux;
            aux = oFrmCadFuncionarios.btnSalvar.Text;
            oFrmCadFuncionarios.btnSalvar.Text = "&Excluir";
            oFrmCadFuncionarios.ConhecaObj(oSel, oCtrlFuncionarios);
            oFrmCadFuncionarios.LimpaTxt();
            oFrmCadFuncionarios.BloquearTxt();
            oFrmCadFuncionarios.CarregaTxt();
            oFrmCadFuncionarios.ShowDialog();
            oFrmCadFuncionarios.DesbloquearTxt();
            oFrmCadFuncionarios.btnSalvar.Text = aux;
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void brnSair_Click(object sender, EventArgs e)
        {

        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}