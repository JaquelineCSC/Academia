namespace Academia
{
    partial class FrmSeleçãoConsulta
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
            this.cmbPesquisa = new MetroFramework.Controls.MetroComboBox();
            this.cmdEntrar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbPesquisa
            // 
            this.cmbPesquisa.FormattingEnabled = true;
            this.cmbPesquisa.ItemHeight = 23;
            this.cmbPesquisa.Items.AddRange(new object[] {
            "Alimento",
            "Cliente",
            "Exercicio",
            "Profissional"});
            this.cmbPesquisa.Location = new System.Drawing.Point(104, 103);
            this.cmbPesquisa.Name = "cmbPesquisa";
            this.cmbPesquisa.Size = new System.Drawing.Size(427, 29);
            this.cmbPesquisa.TabIndex = 0;
            this.cmbPesquisa.UseSelectable = true;
            this.cmbPesquisa.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisa_SelectedIndexChanged);
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.Enabled = false;
            this.cmdEntrar.Location = new System.Drawing.Point(591, 85);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(152, 69);
            this.cmdEntrar.TabIndex = 1;
            this.cmdEntrar.Text = "Consultar";
            this.cmdEntrar.UseSelectable = true;
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // FrmSeleçãoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.cmdEntrar);
            this.Controls.Add(this.cmbPesquisa);
            this.Name = "FrmSeleçãoConsulta";
            this.Text = "Seleção de Consulta";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbPesquisa;
        private MetroFramework.Controls.MetroButton cmdEntrar;
    }
}