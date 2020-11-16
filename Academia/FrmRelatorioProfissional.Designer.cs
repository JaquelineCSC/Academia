namespace Academia
{
    partial class FrmRelatorioProfissional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdRelatorioCliente = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmdRelatorioCliente
            // 
            this.cmdRelatorioCliente.Location = new System.Drawing.Point(23, 86);
            this.cmdRelatorioCliente.Name = "cmdRelatorioCliente";
            this.cmdRelatorioCliente.Size = new System.Drawing.Size(486, 108);
            this.cmdRelatorioCliente.TabIndex = 1;
            this.cmdRelatorioCliente.Text = "Relatorio Profissional";
            this.cmdRelatorioCliente.UseSelectable = true;
            this.cmdRelatorioCliente.Click += new System.EventHandler(this.cmdRelatorioCliente_Click);
            // 
            // FrmRelatorioProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 240);
            this.Controls.Add(this.cmdRelatorioCliente);
            this.Name = "FrmRelatorioProfissional";
            this.Text = "Relatorio Profissional";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmRelatorioProfissional_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdRelatorioCliente;
    }
}