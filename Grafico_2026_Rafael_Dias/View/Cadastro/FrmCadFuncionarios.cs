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
    public partial class FrmCadFuncionarios : Grafico_2026_Rafael_Dias.View.Cadastro.FrmCadastro
    {
        private Funcionarios oFuncionario;
        protected FrmConCargos oFrmConCargos;
        protected FrmConCidades oFrmConCidades;
        private CtrlFuncionarios oCtrlFuncionarios;
        public FrmCadFuncionarios()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            oFuncionario = (Funcionarios)obj;
            oCtrlFuncionarios = (CtrlFuncionarios)ctrl;
        }

        public void SetFrmConsulta(object obj, object obj2)
        {
            oFrmConCargos = (FrmConCargos)obj;
            oFrmConCidades = (FrmConCidades)obj2;
        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtCodigo.Text = "0";
            this.lblDatCad.Enabled = false;
            this.lblUltAlt.Enabled = false;
            this.lblCodUsu.Enabled = false;
            this.txtNome.Clear();
            this.txtIdade.Clear();
            this.txtSexo.Clear();
            this.txtNumDependentes.Clear();
            this.txtMatricula.Clear();
            this.txtCodCargo.Clear();
            this.txtCargo.Clear();
            this.txtCep.Clear();
            this.txtLogradouro.Clear();
            this.txtNumero.Clear();
            this.txtComplemento.Clear();
            this.txtBairro.Clear();
            this.txtCodCidade.Clear();
            this.txtCidade.Clear();
            this.txtCpf.Clear();
            this.txtCnh.Clear();
            this.txtValCnh.Clear();
            this.txtTipoCnh.Clear();
            this.txtSalBase.Clear();
            this.txtGratificacao.Clear();
        }

        public override void CarregaTxt()
        {
            this.txtCodigo.Text = oFuncionario.Codigo.ToString();
            this.lblDatCad.Text = oFuncionario.DataCadastro.ToString();
            this.lblUltAlt.Text = oFuncionario.DataAlteracao.ToString();
            this.lblCodUsu.Text = oFuncionario.CodigoUsuario.ToString();
            this.txtNome.Text = oFuncionario.Nome;
            this.txtIdade.Text = oFuncionario.Idade.ToString();
            this.txtSexo.Text = oFuncionario.Sexo.ToString();
            this.txtNumDependentes.Text = oFuncionario.NumDep.ToString();
            this.txtMatricula.Text = oFuncionario.Matricula;
            this.txtCodCargo.Text = oFuncionario.OCargo.Codigo.ToString();
            this.txtCargo.Text = oFuncionario.OCargo.Cargo;
            this.txtCep.Text = oFuncionario.Cep;
            this.txtLogradouro.Text = oFuncionario.Logradouro;
            this.txtNumero.Text = oFuncionario.Numero.ToString();
            this.txtComplemento.Text = oFuncionario.Complemento;
            this.txtBairro.Text = oFuncionario.Bairro;
            this.txtCodCidade.Text = oFuncionario.OCidade.Codigo.ToString();
            this.txtCidade.Text = oFuncionario.OCidade.Cidade;
            this.txtCpf.Text = oFuncionario.Cpf;
            this.txtCnh.Text = oFuncionario.Cnh;
            this.txtValCnh.Text = oFuncionario.DataValidadeCnh;
            this.txtTipoCnh.Text = oFuncionario.TipoCnh.ToString();
            this.txtSalBase.Text = oFuncionario.SalBase.ToString();
            this.txtGratificacao.Text = oFuncionario.Gratificacao.ToString();
        }

        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled = false;
            this.lblDatCad.Enabled = false;
            this.lblUltAlt.Enabled = false;
            this.lblCodUsu.Enabled = false;
            this.txtNome.Enabled = false;
            this.txtIdade.Enabled = false;
            this.txtSexo.Enabled = false;
            this.txtNumDependentes.Enabled = false;
            this.txtMatricula.Enabled = false;
            this.txtCodCargo.Enabled = false;
            this.txtCargo.Enabled = false;
            this.txtCep.Enabled = false;
            this.txtLogradouro.Enabled = false;
            this.txtNumero.Enabled = false;
            this.txtComplemento.Enabled = false;
            this.txtBairro.Enabled = false;
            this.txtCodCidade.Enabled = false;
            this.txtCidade.Enabled = false;
            this.txtCpf.Enabled = false;
            this.txtCnh.Enabled = false;
            this.txtValCnh.Enabled = false;
            this.txtTipoCnh.Enabled = false;
            this.txtSalBase.Enabled = false;
            this.txtGratificacao.Enabled = false;
        }

        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled = true;
            this.lblDatCad.Enabled = true;
            this.lblUltAlt.Enabled = true;
            this.lblCodUsu.Enabled = true;
            this.txtNome.Enabled = true;
            this.txtIdade.Enabled = true;
            this.txtSexo.Enabled = true;
            this.txtNumDependentes.Enabled = true;
            this.txtMatricula.Enabled = true;
            this.txtCodCargo.Enabled = true;
            this.txtCargo.Enabled = true;
            this.txtCep.Enabled = true;
            this.txtLogradouro.Enabled = true;
            this.txtNumero.Enabled = true;
            this.txtComplemento.Enabled = true;
            this.txtBairro.Enabled = true;
            this.txtCodCidade.Enabled = true;
            this.txtCidade.Enabled = true;
            this.txtCpf.Enabled = true;
            this.txtCnh.Enabled = true;
            this.txtValCnh.Enabled = true;
            this.txtTipoCnh.Enabled = true;
            this.txtSalBase.Enabled = true;
            this.txtGratificacao.Enabled = true;
        }

        public override void Salvar()
        {
            string msg;
            oFuncionario.Codigo = Convert.ToInt32(this.txtCodigo.Text);
            oFuncionario.Nome = this.txtNome.Text;
            oFuncionario.Idade = Convert.ToInt32(this.txtIdade.Text);
            oFuncionario.Sexo = this.txtSexo.Text.Length > 0 ? Char.ToUpper(this.txtSexo.Text[0]) : ' ';
            oFuncionario.NumDep = Convert.ToInt32(this.txtNumDependentes.Text);
            oFuncionario.Matricula = this.txtMatricula.Text;
            oFuncionario.Cpf = this.txtCpf.Text;
            oFuncionario.OCargo.Codigo = Convert.ToInt32(this.txtCodCargo.Text);
            oFuncionario.OCargo.Cargo = this.txtCargo.Text;
            oFuncionario.Cep = this.txtCep.Text;
            oFuncionario.Logradouro = this.txtLogradouro.Text;
            oFuncionario.Numero = Convert.ToInt32(this.txtNumero.Text);
            oFuncionario.Complemento = this.txtComplemento.Text;
            oFuncionario.Bairro = this.txtBairro.Text;
            oFuncionario.OCidade.Codigo = Convert.ToInt32(this.txtCodCidade.Text);
            oFuncionario.OCidade.Cidade = this.txtCidade.Text;
            oFuncionario.Cnh = this.txtCnh.Text;
            oFuncionario.DataValidadeCnh = this.txtValCnh.Text;
            oFuncionario.TipoCnh = this.txtTipoCnh.Text.Length > 0 ? char.ToUpper(this.txtTipoCnh.Text[0]) : ' ';
            oFuncionario.SalBase = Convert.ToDouble(this.txtSalBase.Text);
            oFuncionario.Gratificacao = Convert.ToDouble(this.txtGratificacao.Text);
            if (btnSalvar.Text != "&Excluir")
                msg = oCtrlFuncionarios.Salvar(oFuncionario);
            else
                msg = oCtrlFuncionarios.Excluir(oFuncionario);
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

        private void btnPesquisarCidade_Click(object sender, EventArgs e)
        {
            string aux = oFrmConCidades.btnSair.Text;
            oFrmConCidades.btnSair.Text = "&Selecionar";
            oFrmConCidades.ConhecaObj(oFuncionario.OCidade, oCtrlFuncionarios.OCtrlCidades);
            oFrmConCidades.ShowDialog();
            this.txtCodCidade.Text = oFuncionario.OCidade.Codigo.ToString();
            this.txtCidade.Text = oFuncionario.OCidade.Cidade;
            oFrmConCidades.btnSair.Text = aux;
        }

        private void btnPesquisarCargo_Click(object sender, EventArgs e)
        {
            string aux = oFrmConCargos.btnSair.Text;
            oFrmConCargos.btnSair.Text = "&Selecionar";
            oFrmConCargos.ConhecaObj(oFuncionario.OCargo, oCtrlFuncionarios.OCtrlCargos);
            oFrmConCargos.ShowDialog();
            this.txtCodCargo.Text = oFuncionario.OCargo.Codigo.ToString();
            this.txtCargo.Text = oFuncionario.OCargo.Cargo;
            oFrmConCargos.btnSair.Text = aux;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}