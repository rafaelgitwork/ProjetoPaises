using Grafico_2026_Rafael_Dias.Controller;
using Grafico_2026_Rafael_Dias.Model;
using Grafico_2026_Rafael_Dias.View.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Grafico_2026_Rafael_Dias.View.Cadastro
{
    public partial class FrmCadCidades : Grafico_2026_Rafael_Dias.View.Cadastro.FrmCadastro
    {
        private Cidades oCidade;
        private FrmConEstados oFrmConEstados;
        private CtrlCidades oCtrlCidades;
        public FrmCadCidades()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oCidade = (Cidades)obj;
            oCtrlCidades = (CtrlCidades)ctrl;
        }

        public override void SetFrmConsulta(object obj)
        {
            oFrmConEstados = (FrmConEstados)obj;
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Text = "0";
            this.lblDatCad.Text = String.Empty;
            this.lblUltAlt.Text = String.Empty;
            this.lblCodUsu.Text = String.Empty;
            this.txtCidade.Clear();
            this.txtDdd.Clear();
            this.txtCodEstado.Clear();
            this.txtEstado.Clear();
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text    = oCidade.Codigo.ToString();
            this.lblDatCad.Text    = oCidade.DataCadastro.ToString();
            this.lblUltAlt.Text    = oCidade.DataAlteracao.ToString();
            this.lblCodUsu.Text    = oCidade.CodigoUsuario.ToString();
            this.txtCidade.Text    = oCidade.Cidade;
            this.txtDdd.Text       = oCidade.DDD;
            this.txtCodEstado.Text = oCidade.OEstado.Codigo.ToString();
            this.txtEstado.Text    = oCidade.OEstado.Estado;
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled    = false;
            this.lblDatCad.Enabled    = false;
            this.lblUltAlt.Enabled    = false;
            this.lblCodUsu.Enabled    = false;
            this.txtCidade.Enabled    = false;
            this.txtDdd.Enabled       = false;
            this.txtCodEstado.Enabled = false;
            this.txtEstado.Enabled    = false;
            this.btnPesquisar.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled    = true;
            this.lblDatCad.Enabled    = true;
            this.lblUltAlt.Enabled    = true;
            this.lblCodUsu.Enabled    = true;
            this.txtCidade.Enabled    = true;
            this.txtDdd.Enabled       = true;
            this.txtCodEstado.Enabled = true;
            this.txtEstado.Enabled    = true;
            this.btnPesquisar.Enabled = true;
        }

        public override void Salvar()
        {
            if (txtCidade.Text == string.Empty)
            {
                txtCidade.Focus();
            }
            if (txtCodEstado.Text == string.Empty)
            {
                txtDdd.Focus();
            }
            string msg;
            oCidade.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            oCidade.Cidade = this.txtCidade.Text;
            oCidade.DDD = this.txtDdd.Text;
            oCidade.OEstado.Codigo = Convert.ToInt32(this.txtCodEstado.Text);
            oCidade.OEstado.Estado = this.txtEstado.Text;
            msg = oCtrlCidades.Salvar(oCidade);
            if (btnSalvar.Text == "Sal&var")
                msg = oCtrlCidades.Salvar(oCidade);
            else
                msg = oCtrlCidades.Excluir(oCidade);
            if
                (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg);
            }
            Sair();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string aux = oFrmConEstados.btnSair.Text;
            oFrmConEstados.btnSair.Text = "&Selecionar";
            oFrmConEstados.ConhecaObj(oCidade.OEstado, oCtrlCidades.OCtrlEstados);
            oFrmConEstados.ShowDialog();
            this.txtCodEstado.Text = oCidade.OEstado.Codigo.ToString();
            this.txtEstado.Text = oCidade.OEstado.Estado;
            oFrmConEstados.btnSair.Text = aux;
        }

        private void FrmCadCidades_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
