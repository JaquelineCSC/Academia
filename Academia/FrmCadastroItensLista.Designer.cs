namespace Academia
{
    partial class FrmCadastroItensLista
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbCliente = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmdSalvarItens = new MetroFramework.Controls.MetroButton();
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
            this.cmbExercicios.Location = new System.Drawing.Point(123, 132);
            this.cmbExercicios.Name = "cmbExercicios";
            this.cmbExercicios.Size = new System.Drawing.Size(249, 29);
            this.cmbExercicios.TabIndex = 71;
            this.cmbExercicios.UseSelectable = true;
            this.cmbExercicios.SelectedIndexChanged += new System.EventHandler(this.cmbExercicios_SelectedIndexChanged);
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAlimento.Location = new System.Drawing.Point(28, 132);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(89, 25);
            this.lblAlimento.TabIndex = 70;
            this.lblAlimento.Text = "Exercicios:";
            // 
            // mbAdicionar
            // 
            this.mbAdicionar.Location = new System.Drawing.Point(390, 132);
            this.mbAdicionar.Name = "mbAdicionar";
            this.mbAdicionar.Size = new System.Drawing.Size(91, 29);
            this.mbAdicionar.TabIndex = 72;
            this.mbAdicionar.Text = "Adicionar";
            this.mbAdicionar.UseSelectable = true;
            this.mbAdicionar.Click += new System.EventHandler(this.mbAdicionar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 212);
            this.listBox1.TabIndex = 76;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.ItemHeight = 23;
            this.cmbCliente.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbCliente.Location = new System.Drawing.Point(123, 88);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(249, 29);
            this.cmbCliente.TabIndex = 78;
            this.cmbCliente.UseSelectable = true;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(28, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 25);
            this.metroLabel1.TabIndex = 77;
            this.metroLabel1.Text = "Cliente:";
            // 
            // cmdSalvarItens
            // 
            this.cmdSalvarItens.Location = new System.Drawing.Point(457, 420);
            this.cmdSalvarItens.Name = "cmdSalvarItens";
            this.cmdSalvarItens.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvarItens.TabIndex = 79;
            this.cmdSalvarItens.Text = "Salvar Itens";
            this.cmdSalvarItens.UseSelectable = true;
            this.cmdSalvarItens.Click += new System.EventHandler(this.cmdSalvarItens_Click);
            // 
            // FrmItensLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 468);
            this.Controls.Add(this.cmdSalvarItens);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbExercicios);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.mbAdicionar);
            this.Name = "FrmItensLista";
            this.Text = "Itens da Lista de Teinos";
            this.Load += new System.EventHandler(this.FrmItensLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbExercicios;
        private MetroFramework.Controls.MetroLabel lblAlimento;
        private MetroFramework.Controls.MetroButton mbAdicionar;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroComboBox cmbCliente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cmdSalvarItens;
    }
}