namespace Grafico_2026_Rafael_Dias.View.Consulta
{
    partial class FrmConFuncionarios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Matricula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalBase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gratificação = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Logradouro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Complemento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataValidadeCnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoCnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.Código,
            this.Nome,
            this.Idade,
            this.Sexo,
            this.Matricula,
            this.Cpf,
            this.CodCargo,
            this.Cargo,
            this.SalBase,
            this.Gratificação,
            this.NumDep,
            this.Cep,
            this.Logradouro,
            this.Número,
            this.Complemento,
            this.Bairro,
            this.CodCidade,
            this.Cidade,
            this.Cnh,
            this.DataValidadeCnh,
            this.TipoCnh});
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // n
            // 
            this.n.Text = "n";
            this.n.Width = 10;
            // 
            // Matricula
            // 
            this.Matricula.Text = "Matricula";
            this.Matricula.Width = 100;
            // 
            // Cpf
            // 
            this.Cpf.Text = "Cpf";
            // 
            // CodCargo
            // 
            this.CodCargo.Text = "CodCargo";
            this.CodCargo.Width = 100;
            // 
            // SalBase
            // 
            this.SalBase.Text = "SalBase";
            this.SalBase.Width = 100;
            // 
            // Gratificação
            // 
            this.Gratificação.Text = "Gratificação";
            this.Gratificação.Width = 100;
            // 
            // NumDep
            // 
            this.NumDep.Text = "Numdep";
            this.NumDep.Width = 100;
            // 
            // Cep
            // 
            this.Cep.Text = "Cep";
            // 
            // Logradouro
            // 
            this.Logradouro.Text = "Logradouro";
            this.Logradouro.Width = 100;
            // 
            // Número
            // 
            this.Número.Text = "Número";
            this.Número.Width = 100;
            // 
            // Complemento
            // 
            this.Complemento.Text = "Complemento";
            this.Complemento.Width = 100;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 100;
            // 
            // CodCidade
            // 
            this.CodCidade.Text = "CodCidade";
            this.CodCidade.Width = 100;
            // 
            // Cnh
            // 
            this.Cnh.Text = "Cnh";
            // 
            // DataValidadeCnh
            // 
            this.DataValidadeCnh.Text = "DataValidadeCnh";
            this.DataValidadeCnh.Width = 100;
            // 
            // TipoCnh
            // 
            this.TipoCnh.Text = "TipoCnh";
            this.TipoCnh.Width = 100;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            // 
            // Idade
            // 
            this.Idade.Text = "Idade";
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            // 
            // Cargo
            // 
            this.Cargo.Text = "Cargo";
            // 
            // Cidade
            // 
            this.Cidade.Text = "Cidade";
            // 
            // Código
            // 
            this.Código.Text = "Código";
            // 
            // FrmConFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "FrmConFuncionarios";
            this.Text = "Consulta de Funcionarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader Matricula;
        private System.Windows.Forms.ColumnHeader Cpf;
        private System.Windows.Forms.ColumnHeader CodCargo;
        private System.Windows.Forms.ColumnHeader SalBase;
        private System.Windows.Forms.ColumnHeader Gratificação;
        private System.Windows.Forms.ColumnHeader NumDep;
        private System.Windows.Forms.ColumnHeader Cep;
        private System.Windows.Forms.ColumnHeader Logradouro;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Complemento;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader CodCidade;
        private System.Windows.Forms.ColumnHeader Cnh;
        private System.Windows.Forms.ColumnHeader DataValidadeCnh;
        private System.Windows.Forms.ColumnHeader TipoCnh;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Idade;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Cargo;
        private System.Windows.Forms.ColumnHeader Cidade;
        private System.Windows.Forms.ColumnHeader Código;
    }
}
