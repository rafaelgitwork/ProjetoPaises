using Grafico_2026_Rafael_Dias.Controller;
using Grafico_2026_Rafael_Dias.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Rafael_Dias.View.Cadastro
{
    public partial class FrmCadPaises : Grafico_2026_Rafael_Dias.View.Cadastro.FrmCadastro
    {
        private Paises oPais;
        private CtrlPaises oCtrlPaises;
        public FrmCadPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oPais = (Paises)obj;
            oCtrlPaises = (CtrlPaises)ctrl;
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Text = "0";
            this.lblDatCad.Text = String.Empty;
            this.lblUltAlt.Text = String.Empty;
            this.lblCodUsu.Text = String.Empty;
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDdi.Clear();
            this.txtMoeda.Clear();
        }

        public override void CarregaTxt()
        { 
            this.txtCodigo.Text = oPais.Codigo.ToString();
            this.lblDatCad.Text = oPais.DataCadastro.ToString();
            this.lblUltAlt.Text = oPais.DataAlteracao.ToString();
            this.lblCodUsu.Text = oPais.CodigoUsuario.ToString();
            this.txtPais.Text   = oPais.Pais;
            this.txtSigla.Text  = oPais.Sigla;
            this.txtDdi.Text    = oPais.DDI;
            this.txtMoeda.Text  = oPais.Moeda;
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtPais.Enabled   = false;
            this.txtSigla.Enabled  = false;
            this.txtDdi.Enabled    = false;
            this.txtMoeda.Enabled  = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtPais.Enabled   = true;
            this.txtSigla.Enabled  = true;
            this.txtDdi.Enabled    = true;
            this.txtMoeda.Enabled  = true;
        }

        public override void Salvar()
        {
            if (string.IsNullOrEmpty(this.txtPais.Text))
            {
                MessageBox.Show("Informe o nome do país.");
                this.txtPais.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtSigla.Text))
            {
                MessageBox.Show("Informe a sigla do país.");
                this.txtSigla.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtDdi.Text))
            {
                MessageBox.Show("Informe o DDI do país.");
                this.txtDdi.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMoeda.Text))
            {
                MessageBox.Show("Informe a moeda do país.");
                this.txtMoeda.Focus();
                return;
            }
            string msg;
            oPais.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            oPais.Pais = this.txtPais.Text;
            oPais.Sigla = this.txtSigla.Text;
            oPais.DDI = this.txtDdi.Text;
            oPais.Moeda = this.txtMoeda.Text;
            msg = oCtrlPaises.Salvar(oPais);
            if (btnSalvar.Text == "Sal&var")
                msg = oCtrlPaises.Salvar(oPais);
            else 
                msg = oCtrlPaises.Excluir(oPais);
            if 
                (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }
            Sair();
        }

        public override void SetFrmConsulta(object obj)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }
    }
}
