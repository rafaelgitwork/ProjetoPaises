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
    public partial class FrmConCargos : Grafico_2026_Rafael_Dias.View.FrmConsulta
    {

        private Cargos oCargo;
        private FrmCadCargos oFrmCadCargos;
        private CtrlCargos oCtrlCargos;
        public FrmConCargos()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCargo = (Cargos)obj;
            oCtrlCargos = (CtrlCargos)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadCargos = (FrmCadCargos)obj;
        }

        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Cargos oCargoFiltro = new Cargos();
            oCargoFiltro.Cargo = txtCodigo.Text.Trim().ToUpper();
            var ListaResultado = new List<Cargos>();
            var lista = oCtrlCargos.Pesquisar(oCargo);
            if (lista != null)
            {
                foreach (var o in lista)
                    ListaResultado.Add((Cargos)o);
            }
            foreach (var ca in ListaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(ca.Codigo.ToString());
                item.SubItems.Add(ca.Cargo);
                item.SubItems.Add(ca.ExigeCnh.ToString());
                item.SubItems.Add(ca.GanhaComissao.ToString());
                LV.Items.Add(item);
            }
            foreach (Cargos ca in oCtrlCargos.Pesquisar(oCargoFiltro))
            {
                AdicionarLinhaLV(ca);
            }
        }
        private void AdicionarLinhaLV(Cargos oCargoA)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(oCargoA.Codigo.ToString());
            item.SubItems.Add(oCargoA.Cargo);
            item.SubItems.Add(oCargoA.ExigeCnh.ToString());
            item.SubItems.Add(oCargoA.GanhaComissao.ToString());
            item.Tag = oCargoA;
            LV.Items.Add(item);
        }
        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count > 0)
            {
                ListViewItem Linha = LV.SelectedItems[0];
                Cargos oCargoSel = (Cargos)Linha.Tag;
                oCargo.Codigo = oCargoSel.Codigo;
                oCargo.Cargo = oCargoSel.Cargo;
                oCargo.ExigeCnh = oCargoSel.ExigeCnh;
                oCargo.GanhaComissao = oCargoSel.GanhaComissao;
            }
        }
        public override void Incluir()
        {
            oFrmCadCargos.ConhecaObj(new Cargos(), oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.CarregaTxt();
            oFrmCadCargos.ShowDialog();
            Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.CarregaTxt();
            oFrmCadCargos.ShowDialog();
            Pesquisar();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCargos.btnSalvar.Text;
            oFrmCadCargos.btnSalvar.Text = "&Excluir";
            oFrmCadCargos.ConhecaObj(oCargo, oCtrlCargos);
            oFrmCadCargos.LimpaTxt();
            oFrmCadCargos.BloquearTxt();
            oFrmCadCargos.CarregaTxt();
            oFrmCadCargos.ShowDialog();
            oFrmCadCargos.DesbloquearTxt();
            oFrmCadCargos.btnSalvar.Text = aux;
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
    }
}
