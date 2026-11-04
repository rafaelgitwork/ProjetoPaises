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
    public partial class FrmConCidades : Grafico_2026_Rafael_Dias.View.FrmConsulta
    {
        private Cidades oCidades;
        private FrmCadCidades oFrmCadCidades;
        private CtrlCidades oCtrlCidades;
        public FrmConCidades()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCidades = (Cidades)obj;
            oCtrlCidades = (CtrlCidades)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadCidades = (FrmCadCidades)obj;
        }

        public override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(oCidades, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(oCidades, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            Pesquisar();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadCidades.btnSalvar.Text;
            oFrmCadCidades.btnSalvar.Text = "&Excluir";
            oFrmCadCidades.ConhecaObj(oCidades, oCtrlCidades);
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.BloquearTxt();
            oFrmCadCidades.CarregaTxt();
            oFrmCadCidades.ShowDialog();
            oFrmCadCidades.DesbloquearTxt();
            oFrmCadCidades.btnSalvar.Text = aux;
            Pesquisar();
        }

        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Cidades oCidadeFiltro = new Cidades();
            oCidadeFiltro.Cidade = txtCodigo.Text.Trim().ToUpper();
            var ListaResultado = new List<Cidades>();
            var lista = oCtrlCidades.Pesquisar(oCidades);
            if (lista != null)
            {
                foreach (var o in lista)
                    ListaResultado.Add((Cidades)o);
            }
            foreach (var e in ListaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(e.Codigo.ToString());
                item.SubItems.Add(e.Cidade);
                item.SubItems.Add(e.DDD);
                item.SubItems.Add(e.OEstado.Codigo.ToString());
                item.SubItems.Add(e.OEstado.Estado);
                LV.Items.Add(item);
            }
            foreach (Cidades e in oCtrlCidades.Pesquisar(oCidadeFiltro))
            {
                AdicionarLinhaLV(e);
            }
        }

        private void AdicionarLinhaLV(Cidades oCidadeA)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(oCidadeA.Codigo.ToString());
            item.SubItems.Add(oCidadeA.Cidade);
            item.SubItems.Add(oCidadeA.DDD);
            item.SubItems.Add(oCidadeA.OEstado.Codigo.ToString());
            item.SubItems.Add(oCidadeA.OEstado.Estado);
            item.Tag = oCidadeA;
            LV.Items.Add(item);
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count > 0)
            {
                ListViewItem Linha = LV.SelectedItems[0];
                Cidades oCidadeSel = (Cidades)Linha.Tag;
                oCidades.Codigo = oCidadeSel.Codigo;
                oCidades.Cidade = oCidadeSel.Cidade;
                oCidades.DDD = oCidadeSel.DDD;
                oCidades.OEstado = oCidadeSel.OEstado;
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