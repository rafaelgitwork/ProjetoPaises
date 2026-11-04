namespace Grafico_2026_Rafael_Dias.View.Consulta
{
    partial class FrmConCargos
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
            this.Cargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExigeCnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GanhaComissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Funcionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LV
            // 
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.Cargo,
            this.ExigeCnh,
            this.GanhaComissao,
            this.CodFuncionario,
            this.Funcionario});
            this.LV.Location = new System.Drawing.Point(70, 130);
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
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
            // Cargo
            // 
            this.Cargo.Text = "Cargo";
            this.Cargo.Width = 150;
            // 
            // ExigeCnh
            // 
            this.ExigeCnh.Text = "ExigeCnh";
            this.ExigeCnh.Width = 95;
            // 
            // GanhaComissao
            // 
            this.GanhaComissao.Text = "GanhaComissao";
            this.GanhaComissao.Width = 133;
            // 
            // CodFuncionario
            // 
            this.CodFuncionario.Text = "CodFuncionario";
            this.CodFuncionario.Width = 125;
            // 
            // Funcionario
            // 
            this.Funcionario.Text = "Funcionario";
            this.Funcionario.Width = 150;
            // 
            // FrmConCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "FrmConCargos";
            this.Text = "Consulta de Cargos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader Cargo;
        private System.Windows.Forms.ColumnHeader ExigeCnh;
        private System.Windows.Forms.ColumnHeader GanhaComissao;
        private System.Windows.Forms.ColumnHeader CodFuncionario;
        private System.Windows.Forms.ColumnHeader Funcionario;
    }
}
