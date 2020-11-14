namespace Academia
{
    partial class FrmRelatorioCliente
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
            this.cmdRelatorioCliente.Location = new System.Drawing.Point(23, 91);
            this.cmdRelatorioCliente.Name = "cmdRelatorioCliente";
            this.cmdRelatorioCliente.Size = new System.Drawing.Size(486, 108);
            this.cmdRelatorioCliente.TabIndex = 0;
            this.cmdRelatorioCliente.Text = "Relatorio Cliente";
            this.cmdRelatorioCliente.UseSelectable = true;
            this.cmdRelatorioCliente.Click += new System.EventHandler(this.cmdRelatorioCliente_Click);
            // 
            // FrmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 248);
            this.Controls.Add(this.cmdRelatorioCliente);
            this.Name = "FrmRelatorioCliente";
            this.Text = "FrmRelatorioCliente";
            this.Load += new System.EventHandler(this.FrmRelatorioCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdRelatorioCliente;
    }
}