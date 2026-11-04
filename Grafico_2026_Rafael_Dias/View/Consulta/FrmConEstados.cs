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
    public partial class FrmConEstados : Grafico_2026_Rafael_Dias.View.FrmConsulta
    {
        private Estados oEstado;
        private FrmCadEstados oFrmCadEstados;
        private CtrlEstados oCtrlEstados;
        public FrmConEstados()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            oCtrlEstados = (CtrlEstados)ctrl;
            this.Pesquisar();
        }

        public override void SetFrmCadastro(object obj)
        {
            oFrmCadEstados = (FrmCadEstados)obj;
        }

        public override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, oCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            Pesquisar();
        }

        public override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, oCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            Pesquisar();
        }

        public override void Excluir()
        {
            string aux;
            aux = oFrmCadEstados.btnSalvar.Text;
            oFrmCadEstados.btnSalvar.Text = "&Excluir";
            oFrmCadEstados.ConhecaObj(oEstado, oCtrlEstados);
            oFrmCadEstados.LimpaTxt();
            oFrmCadEstados.BloquearTxt();
            oFrmCadEstados.CarregaTxt();
            oFrmCadEstados.ShowDialog();
            oFrmCadEstados.DesbloquearTxt();
            oFrmCadEstados.btnSalvar.Text = aux;
            Pesquisar();    
        }
        public override void Pesquisar()
        {
            this.LV.Items.Clear();
            Estados oEstadoFiltro = new Estados();
            oEstadoFiltro.Estado = txtCodigo.Text.Trim().ToUpper();
            var ListaResultado = new List<Estados>();
            var lista = oCtrlEstados.Pesquisar(oEstado);
            if (lista != null)
            {
                foreach (var o in lista)
                    ListaResultado.Add((Estados)o);
            }
            foreach (var e in ListaResultado)
            {
                ListViewItem item = new ListViewItem(".");
                item.SubItems.Add(e.Codigo.ToString());
                item.SubItems.Add(e.Estado);
                item.SubItems.Add(e.UF);
                item.SubItems.Add(e.OPais.Codigo.ToString());
                item.SubItems.Add(e.OPais.Pais);
                LV.Items.Add(item);
            }
            foreach (Estados e in oCtrlEstados.Pesquisar(oEstadoFiltro))
            {
                AdicionarLinhaLV(e);
            }
        }
        private void AdicionarLinhaLV(Estados oEstadoA)
        {
            ListViewItem item = new ListViewItem(".");
            item.SubItems.Add(oEstadoA.Codigo.ToString());
            item.SubItems.Add(oEstadoA.Estado);
            item.SubItems.Add(oEstadoA.UF);
            item.SubItems.Add(oEstadoA.OPais.Codigo.ToString());
            item.SubItems.Add(oEstadoA.OPais.Pais);
            item.Tag = oEstadoA;
            LV.Items.Add(item);
        }

        private void LV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count > 0)
            {
                ListViewItem Linha = LV.SelectedItems[0];
                Estados oEstadoSel = (Estados)Linha.Tag;
                oEstado.Codigo = oEstadoSel.Codigo;
                oEstado.Estado = oEstadoSel.Estado;
                oEstado.UF = oEstadoSel.UF;
                oEstado.OPais = oEstadoSel.OPais;
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
