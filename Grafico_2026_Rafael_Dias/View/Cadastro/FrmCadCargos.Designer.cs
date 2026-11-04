namespace Grafico_2026_Rafael_Dias.View.Cadastro
{
    partial class FrmCadCargos
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
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblExigeCnh = new System.Windows.Forms.Label();
            this.lblComissao = new System.Windows.Forms.Label();
            this.cboxExigeCnh = new System.Windows.Forms.CheckBox();
            this.cboxGanhaComissao = new System.Windows.Forms.CheckBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(172, 61);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // lblExigeCnh
            // 
            this.lblExigeCnh.AutoSize = true;
            this.lblExigeCnh.Location = new System.Drawing.Point(333, 61);
            this.lblExigeCnh.Name = "lblExigeCnh";
            this.lblExigeCnh.Size = new System.Drawing.Size(43, 20);
            this.lblExigeCnh.TabIndex = 5;
            this.lblExigeCnh.Text = "CNH";
            // 
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Location = new System.Drawing.Point(412, 62);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(79, 20);
            this.lblComissao.TabIndex = 7;
            this.lblComissao.Text = "Comissão";
            // 
            // cboxExigeCnh
            // 
            this.cboxExigeCnh.AutoSize = true;
            this.cboxExigeCnh.Location = new System.Drawing.Point(336, 94);
            this.cboxExigeCnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxExigeCnh.Name = "cboxExigeCnh";
            this.cboxExigeCnh.Size = new System.Drawing.Size(22, 21);
            this.cboxExigeCnh.TabIndex = 6;
            this.cboxExigeCnh.UseVisualStyleBackColor = true;
            // 
            // cboxGanhaComissao
            // 
            this.cboxGanhaComissao.AutoSize = true;
            this.cboxGanhaComissao.Location = new System.Drawing.Point(438, 92);
            this.cboxGanhaComissao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxGanhaComissao.Name = "cboxGanhaComissao";
            this.cboxGanhaComissao.Size = new System.Drawing.Size(22, 21);
            this.cboxGanhaComissao.TabIndex = 8;
            this.cboxGanhaComissao.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(176, 88);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(120, 26);
            this.txtCargo.TabIndex = 4;
            // 
            // FrmCadCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.cboxGanhaComissao);
            this.Controls.Add(this.cboxExigeCnh);
            this.Controls.Add(this.lblComissao);
            this.Controls.Add(this.lblExigeCnh);
            this.Controls.Add(this.lblCargo);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "FrmCadCargos";
            this.Text = "Cadastro de Cargos";
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
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.lblExigeCnh, 0);
            this.Controls.SetChildIndex(this.lblComissao, 0);
            this.Controls.SetChildIndex(this.cboxExigeCnh, 0);
            this.Controls.SetChildIndex(this.cboxGanhaComissao, 0);
            this.Controls.SetChildIndex(this.txtCargo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCargo;
        protected System.Windows.Forms.Label lblExigeCnh;
        protected System.Windows.Forms.CheckBox cboxExigeCnh;
        protected System.Windows.Forms.TextBox txtCargo;
        protected System.Windows.Forms.Label lblComissao;
        protected System.Windows.Forms.CheckBox cboxGanhaComissao;
    }
}
