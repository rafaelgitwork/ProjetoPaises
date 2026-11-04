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
    public partial class FrmConPaises : Grafico_2026_Rafael_Dias.View.FrmConsulta
    {
        private Paises oPais;
        private FrmCadPaises oFrmCadPaises;
        private CtrlPaises oCtrlPaises;
        public FrmConPaises()
        {
            InitializeComponent();
        }

        private void FrmConPaises_Load(object sender, EventArgs e)
        {

        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oPais = (Paises)obj;
            oCtrlPaises = (CtrlPaises)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadPaises = (FrmCadPaises)obj;
        }

        public override void Incluir()
        {
            oFrmCadPaises.ConhecaObj(oPais, oCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadPaises.ConhecaObj(oPais, oCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            Pesquisar();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadPaises.btnSalvar.Text;
            oFrmCadPaises.btnSalvar.Text = "&Excluir";
            oFrmCadPaises.ConhecaObj(oPais, oCtrlPaises);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.BloquearTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.btnSalvar.Text = aux;
            oFrmCadPaises.DesbloquearTxt();
            Pesquisar();
        }
        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Paises oPaisFiltro = new Paises();
            oPaisFiltro.Pais = txtCodigo.Text.Trim().ToUpper();
            var ListaResultado = new List<Paises>();
            var lista = oCtrlPaises.Pesquisar(oPais);
            if (lista != null)
            {
                foreach (var o in lista)
                    ListaResultado.Add((Paises)o);
            }

            foreach (var p in ListaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(p.Codigo.ToString());
                item.SubItems.Add(p.Pais);
                item.SubItems.Add(p.Sigla);
                item.SubItems.Add(p.DDI);
                item.SubItems.Add(p.Moeda);
                LV.Items.Add(item);
            }
            foreach(Paises o in oCtrlPaises.Pesquisar(oPaisFiltro))
            {
                AdicionarLinhaLV(o);
            }
        }
        private void AdicionarLinhaLV(Paises oPaisA)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(oPaisA.Codigo.ToString());
            item.SubItems.Add(oPaisA.Pais);
            item.SubItems.Add(oPaisA.Sigla);
            item.SubItems.Add(oPaisA.DDI);
            item.SubItems.Add(oPaisA.Moeda);
            item.Tag = oPaisA;
            LV.Items.Add(item);
        }
        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.LV.SelectedItems.Count > 0)
            {
                ListViewItem Linha = LV.SelectedItems[0];
                Paises oPaisSel = (Paises)Linha.Tag;
                oPais.Codigo = oPaisSel.Codigo;
                oPais.Pais = oPaisSel.Pais;
                oPais.Sigla = oPaisSel.Sigla;
                oPais.DDI = oPaisSel.DDI;
                oPais.Moeda = oPaisSel.Moeda;
            }
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
