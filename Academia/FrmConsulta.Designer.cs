namespace Academia
{
    partial class FrmConsulta
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
            this.cmbTabela = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // cmbTabela
            // 
            this.cmbTabela.AutoCompleteCustomSource.AddRange(new string[] {
            "Consulta por Nome Cliente",
            "Consulta por Nome Profissional",
            "Consulta por Area Muscular",
            "Consulta Alimentos",
            "Consulta Cardapio"});
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.ItemHeight = 23;
            this.cmbTabela.Location = new System.Drawing.Point(198, 82);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(884, 29);
            this.cmbTabela.TabIndex = 1;
            this.cmbTabela.UseSelectable = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 781);
            this.Controls.Add(this.cmbTabela);
            this.Name = "FrmConsulta";
            this.Text = "Consultas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbTabela;
    }
}