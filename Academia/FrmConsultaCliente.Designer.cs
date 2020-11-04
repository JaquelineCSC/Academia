namespace Academia
{
    partial class FrmConsultaCliente
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
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbTabela = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(110, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 547);
            this.panel1.TabIndex = 1;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            // 
            // cmbTabela
            // 
            this.cmbTabela.FormattingEnabled = true;
            this.cmbTabela.ItemHeight = 23;
            this.cmbTabela.Items.AddRange(new object[] {
            "Cliente",
            "Exercicio",
            "Profissional"});
            this.cmbTabela.Location = new System.Drawing.Point(228, 63);
            this.cmbTabela.Name = "cmbTabela";
            this.cmbTabela.Size = new System.Drawing.Size(815, 29);
            this.cmbTabela.TabIndex = 3;
            this.cmbTabela.UseSelectable = true;
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 781);
            this.Controls.Add(this.cmbTabela);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConsultaCliente";
            this.Text = "Consultas";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel panel1;
        private MetroFramework.Controls.MetroComboBox cmbTabela;
    }
}