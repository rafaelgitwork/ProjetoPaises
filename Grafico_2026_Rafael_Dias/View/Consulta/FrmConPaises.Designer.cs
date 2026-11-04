namespace Grafico_2026_Rafael_Dias.View.Consulta
{
    partial class FrmConPaises
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
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.País = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Moeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Codigo,
            this.País,
            this.Sigla,
            this.DDI,
            this.Moeda});
            this.LV.Location = new System.Drawing.Point(70, 115);
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
            this.n.Text = ".";
            this.n.Width = 10;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Codigo.Width = 80;
            // 
            // País
            // 
            this.País.Text = "País";
            this.País.Width = 150;
            // 
            // Sigla
            // 
            this.Sigla.Text = "Sigla";
            this.Sigla.Width = 80;
            // 
            // Moeda
            // 
            this.Moeda.Text = "Moeda";
            this.Moeda.Width = 80;
            // 
            // DDI
            // 
            this.DDI.Text = "DDI";
            this.DDI.Width = 80;
            // 
            // FrmConPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.Name = "FrmConPaises";
            this.Text = "Consulta de Paises";
            this.Load += new System.EventHandler(this.FrmConPaises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader País;
        private System.Windows.Forms.ColumnHeader Sigla;
        private System.Windows.Forms.ColumnHeader Moeda;
        private System.Windows.Forms.ColumnHeader DDI;
    }
}
