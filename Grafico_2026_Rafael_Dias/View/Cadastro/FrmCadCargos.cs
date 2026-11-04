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
    public partial class FrmCadCargos : Grafico_2026_Rafael_Dias.View.Cadastro.FrmCadastro
    {
        private Cargos oCargo;
        private CtrlCargos oCtrlCargos;
        public FrmCadCargos()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCargo = (Cargos)obj;
            oCtrlCargos = (CtrlCargos)ctrl;
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Text = "0";
            this.lblDatCad.Text = String.Empty;
            this.lblUltAlt.Text = String.Empty;
            this.lblCodUsu.Text = String.Empty;
            this.txtCargo.Clear();
            this.cboxExigeCnh.Checked = false;
            this.cboxGanhaComissao.Checked = false;
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text            = oCargo.Codigo.ToString();
            this.lblDatCad.Text            = oCargo.DataCadastro.ToString();
            this.lblUltAlt.Text            = oCargo.DataAlteracao.ToString();
            this.lblCodUsu.Text            = oCargo.CodigoUsuario.ToString();
            this.txtCargo.Text             = oCargo.Cargo;
            this.cboxExigeCnh.Checked      = oCargo.ExigeCnh;
            this.cboxGanhaComissao.Checked = oCargo.GanhaComissao;
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled         = false;
            this.txtCargo.Enabled          = false;
            this.cboxExigeCnh.Enabled      = false;
            this.cboxGanhaComissao.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled         = true;
            this.txtCargo.Enabled          = true;
            this.cboxExigeCnh.Enabled      = true;
            this.cboxGanhaComissao.Enabled = true;
        }

        public override void Salvar()
        {
            string msg;
            oCargo.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            oCargo.Cargo = txtCargo.Text;
            oCargo.ExigeCnh = cboxExigeCnh.Checked;
            oCargo.GanhaComissao = cboxGanhaComissao.Checked;
            msg = oCtrlCargos.Salvar(oCargo);
            if (btnSalvar.Text != "&Excluir")
            {
                msg = oCtrlCargos.Salvar(oCargo);
            }
            else
                msg = oCtrlCargos.Excluir(oCargo);
            if (!string.IsNullOrEmpty(msg))
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
            Salvar();
        }
    }
}
