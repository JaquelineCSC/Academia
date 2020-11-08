namespace Academia
{
    partial class FrmItensLista
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
            this.cmbExercicios = new MetroFramework.Controls.MetroComboBox();
            this.lblAlimento = new MetroFramework.Controls.MetroLabel();
            this.mbAdicionar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbExercicios
            // 
            this.cmbExercicios.FormattingEnabled = true;
            this.cmbExercicios.ItemHeight = 23;
            this.cmbExercicios.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbExercicios.Location = new System.Drawing.Point(159, 211);
            this.cmbExercicios.Name = "cmbExercicios";
            this.cmbExercicios.Size = new System.Drawing.Size(430, 29);
            this.cmbExercicios.TabIndex = 71;
            this.cmbExercicios.UseSelectable = true;
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAlimento.Location = new System.Drawing.Point(50, 211);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(89, 25);
            this.lblAlimento.TabIndex = 70;
            this.lblAlimento.Text = "Exercicios:";
            // 
            // mbAdicionar
            // 
            this.mbAdicionar.Location = new System.Drawing.Point(612, 211);
            this.mbAdicionar.Name = "mbAdicionar";
            this.mbAdicionar.Size = new System.Drawing.Size(91, 29);
            this.mbAdicionar.TabIndex = 72;
            this.mbAdicionar.Text = "Adicionar";
            this.mbAdicionar.UseSelectable = true;
            // 
            // FrmItensLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbExercicios);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.mbAdicionar);
            this.Name = "FrmItensLista";
            this.Text = "FrmItensLista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbExercicios;
        private MetroFramework.Controls.MetroLabel lblAlimento;
        private MetroFramework.Controls.MetroButton mbAdicionar;
    }
}