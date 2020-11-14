namespace Academia
{
    partial class FrmSeleçãoRelatorios
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
            this.cmdSelecionar = new MetroFramework.Controls.MetroButton();
            this.cmbPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // cmdSelecionar
            // 
            this.cmdSelecionar.Location = new System.Drawing.Point(555, 116);
            this.cmdSelecionar.Name = "cmdSelecionar";
            this.cmdSelecionar.Size = new System.Drawing.Size(152, 69);
            this.cmdSelecionar.TabIndex = 3;
            this.cmdSelecionar.Text = "Selecionar";
            this.cmdSelecionar.UseSelectable = true;
            this.cmdSelecionar.Click += new System.EventHandler(this.cmdSelecionar_Click);
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.ItemHeight = 23;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Relatorio Cliente",
            "Relatorio Profissional"});
            this.cmbPesquisa.Location = new System.Drawing.Point(68, 134);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(427, 29);
            this.cmbPesquisa.TabIndex = 2;
            this.cmbPesquisa.UseSelectable = true;
            // 
            // FrmSeleçãoRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.cmdSelecionar);
            this.Controls.Add(this.cmbPesquisa);
            this.Name = "FrmSeleçãoRelatorios";
            this.Text = "Seleção Relatorios";
            this.Load += new System.EventHandler(this.FrmSeleçãoRelatorios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton cmdSelecionar;
        private MetroFramework.Controls.MetroComboBox cmbPesquisa;
    }
}