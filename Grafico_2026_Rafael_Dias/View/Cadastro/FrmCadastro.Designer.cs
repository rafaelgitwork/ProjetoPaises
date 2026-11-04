namespace Grafico_2026_Rafael_Dias.View.Cadastro
{
    partial class FrmCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDatCadlbl = new System.Windows.Forms.Label();
            this.lblUltAltlbl = new System.Windows.Forms.Label();
            this.lblCodUsulbl = new System.Windows.Forms.Label();
            this.lblCodUsu = new System.Windows.Forms.Label();
            this.lblUltAlt = new System.Windows.Forms.Label();
            this.lblDatCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnSair
            // 
            this.btnSair.TabIndex = 21;
            this.btnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Size = new System.Drawing.Size(50, 20);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(565, 387);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Sal&var";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDatCadlbl
            // 
            this.lblDatCadlbl.AutoSize = true;
            this.lblDatCadlbl.Location = new System.Drawing.Point(61, 387);
            this.lblDatCadlbl.Name = "lblDatCadlbl";
            this.lblDatCadlbl.Size = new System.Drawing.Size(75, 13);
            this.lblDatCadlbl.TabIndex = 14;
            this.lblDatCadlbl.Text = "Data Cadastro";
            // 
            // lblUltAltlbl
            // 
            this.lblUltAltlbl.AutoSize = true;
            this.lblUltAltlbl.Location = new System.Drawing.Point(194, 387);
            this.lblUltAltlbl.Name = "lblUltAltlbl";
            this.lblUltAltlbl.Size = new System.Drawing.Size(84, 13);
            this.lblUltAltlbl.TabIndex = 15;
            this.lblUltAltlbl.Text = "Ultima Alteração";
            // 
            // lblCodUsulbl
            // 
            this.lblCodUsulbl.AutoSize = true;
            this.lblCodUsulbl.Location = new System.Drawing.Point(344, 387);
            this.lblCodUsulbl.Name = "lblCodUsulbl";
            this.lblCodUsulbl.Size = new System.Drawing.Size(79, 13);
            this.lblCodUsulbl.TabIndex = 16;
            this.lblCodUsulbl.Text = "Código Usuário";
            // 
            // lblCodUsu
            // 
            this.lblCodUsu.AutoSize = true;
            this.lblCodUsu.Location = new System.Drawing.Point(344, 409);
            this.lblCodUsu.Name = "lblCodUsu";
            this.lblCodUsu.Size = new System.Drawing.Size(0, 13);
            this.lblCodUsu.TabIndex = 19;
            // 
            // lblUltAlt
            // 
            this.lblUltAlt.AutoSize = true;
            this.lblUltAlt.Location = new System.Drawing.Point(194, 409);
            this.lblUltAlt.Name = "lblUltAlt";
            this.lblUltAlt.Size = new System.Drawing.Size(0, 13);
            this.lblUltAlt.TabIndex = 18;
            // 
            // lblDatCad
            // 
            this.lblDatCad.AutoSize = true;
            this.lblDatCad.Location = new System.Drawing.Point(61, 409);
            this.lblDatCad.Name = "lblDatCad";
            this.lblDatCad.Size = new System.Drawing.Size(0, 13);
            this.lblDatCad.TabIndex = 17;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCodUsu);
            this.Controls.Add(this.lblUltAlt);
            this.Controls.Add(this.lblDatCad);
            this.Controls.Add(this.lblCodUsulbl);
            this.Controls.Add(this.lblUltAltlbl);
            this.Controls.Add(this.lblDatCadlbl);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmCadastro";
            this.Text = " ";
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCadlbl, 0);
            this.Controls.SetChildIndex(this.lblUltAltlbl, 0);
            this.Controls.SetChildIndex(this.lblCodUsulbl, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblUltAlt, 0);
            this.Controls.SetChildIndex(this.lblCodUsu, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblDatCadlbl;
        protected System.Windows.Forms.Label lblUltAltlbl;
        protected System.Windows.Forms.Label lblUltAlt;
        protected System.Windows.Forms.Label lblDatCad;
        protected System.Windows.Forms.Label lblCodUsulbl;
        protected System.Windows.Forms.Label lblCodUsu;
        public System.Windows.Forms.Button btnSalvar;
    }
}
