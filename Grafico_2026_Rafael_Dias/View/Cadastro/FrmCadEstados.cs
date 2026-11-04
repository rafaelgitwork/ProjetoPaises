using Grafico_2026_Rafael_Dias.Controller;
using Grafico_2026_Rafael_Dias.Model;
using Grafico_2026_Rafael_Dias.View.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Rafael_Dias.View.Cadastro
{
    public partial class FrmCadEstados : Grafico_2026_Rafael_Dias.View.Cadastro.FrmCadastro
    {
        private Estados oEstado;
        private FrmConPaises oFrmConPaises;
        private CtrlEstados oCtrlEstados;
        public FrmCadEstados()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            oCtrlEstados = (CtrlEstados)ctrl;
        }

        public override void SetFrmConsulta(object obj)
        {
            oFrmConPaises = (FrmConPaises)obj;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Text = "0";
            this.lblDatCad.Text = String.Empty;
            this.lblUltAlt.Text = String.Empty;
            this.lblCodUsu.Text = String.Empty;
            this.txtEstado.Clear();
            this.txtUf.Clear();
            this.txtCodPais.Clear();
            this.txtPais.Clear();
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text  = oEstado.Codigo.ToString();
            this.lblDatCad.Text  = oEstado.DataCadastro.ToString();
            this.lblUltAlt.Text  = oEstado.DataAlteracao.ToString();
            this.lblCodUsu.Text  = oEstado.CodigoUsuario.ToString();
            this.txtEstado.Text  = oEstado.Estado;
            this.txtUf.Text      = oEstado.UF;
            this.txtCodPais.Text = oEstado.OPais.Codigo.ToString();
            this.txtPais.Text    = oEstado.OPais.Pais;
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled    = false;
            this.lblDatCad.Enabled    = false;
            this.lblUltAlt.Enabled    = false;
            this.lblCodUsu.Enabled    = false;
            this.txtEstado.Enabled    = false;
            this.txtUf.Enabled        = false;
            this.txtCodPais.Enabled   = false;
            this.txtPais.Enabled      = false;
            this.btnPesquisar.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled    = true;
            this.lblDatCad.Enabled    = true;
            this.lblUltAlt.Enabled    = true;
            this.lblCodUsu.Enabled    = true;
            this.txtEstado.Enabled    = true;
            this.txtUf.Enabled        = true;
            this.txtCodPais.Enabled   = true;
            this.txtPais.Enabled      = true;
            this.btnPesquisar.Enabled = true;
        }

        public override void Salvar()
        {
            if(txtEstado.Text == string.Empty) 
            {
               txtEstado.Focus();
            }
            if (txtCodPais.Text == string.Empty)
            {
                txtUf.Focus();
            }
            string msg;
            oEstado.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            oEstado.Estado       = this.txtEstado.Text;
            oEstado.UF           = this.txtUf.Text;
            oEstado.OPais.Codigo = Convert.ToInt32(this.txtCodPais.Text);
            oEstado.OPais.Pais   = this.txtPais.Text;
            msg                  = oCtrlEstados.Salvar(oEstado);
            if (btnSalvar.Text == "Sal&var")
                msg = oCtrlEstados.Salvar(oEstado);
            else
                msg = oCtrlEstados.Excluir(oEstado);
            if
                (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }
            Sair();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string aux = oFrmConPaises.btnSair.Text;
            string aux2 = this.lblUf.Text;
            oFrmConPaises.btnSair.Text = "Selecionar";
            oFrmConPaises.ConhecaObj(oEstado.OPais, oCtrlEstados.OCtrlPaises);
            oFrmConPaises.ShowDialog();
            this.txtCodPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            this.txtPais.Text = oEstado.OPais.Pais;
            if (oEstado.OPais.Sigla == "BR")
                this.lblUf.Text = this.lblUf.Text + '*';
            oFrmConPaises.btnSair.Text = aux;
            this.lblUf.Text = aux2;
        }
    }
}