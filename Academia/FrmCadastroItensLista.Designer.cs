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
            this.lblNomeCliente = new MetroFramework.Controls.MetroLabel();
            this.lblNomeProfissional = new MetroFramework.Controls.MetroLabel();
            this.cmbNomeExercicio = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbAdicionar = new MetroFramework.Controls.MetroButton();
            this.cmdConcluir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeCliente.Location = new System.Drawing.Point(105, 80);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(64, 25);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.AutoSize = true;
            this.lblNomeProfissional.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeProfissional.Location = new System.Drawing.Point(449, 80);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(98, 25);
            this.lblNomeProfissional.TabIndex = 1;
            this.lblNomeProfissional.Text = "Profissional";
            // 
            // cmbNomeExercicio
            // 
            this.cmbNomeExercicio.FormattingEnabled = true;
            this.cmbNomeExercicio.ItemHeight = 23;
            this.cmbNomeExercicio.Location = new System.Drawing.Point(188, 129);
            this.cmbNomeExercicio.Name = "cmbNomeExercicio";
            this.cmbNomeExercicio.Size = new System.Drawing.Size(482, 29);
            this.cmbNomeExercicio.TabIndex = 2;
            this.cmbNomeExercicio.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(41, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nome Exercicio:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(662, 290);
            this.listBox1.TabIndex = 4;
            // 
            // cmbAdicionar
            // 
            this.cmbAdicionar.Location = new System.Drawing.Point(150, 177);
            this.cmbAdicionar.Name = "cmbAdicionar";
            this.cmbAdicionar.Size = new System.Drawing.Size(95, 41);
            this.cmbAdicionar.TabIndex = 5;
            this.cmbAdicionar.Text = "Adicionar";
            this.cmbAdicionar.UseSelectable = true;
            this.cmbAdicionar.Click += new System.EventHandler(this.cmbAdicionar_Click);
            // 
            // cmdConcluir
            // 
            this.cmdConcluir.Location = new System.Drawing.Point(178, 557);
            this.cmdConcluir.Name = "cmdConcluir";
            this.cmdConcluir.Size = new System.Drawing.Size(359, 41);
            this.cmdConcluir.TabIndex = 6;
            this.cmdConcluir.Text = "Concluir";
            this.cmdConcluir.UseSelectable = true;
            this.cmdConcluir.Click += new System.EventHandler(this.cmdConcluir_Click);
            // 
            // CadastroItensLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 634);
            this.Controls.Add(this.cmdConcluir);
            this.Controls.Add(this.cmbAdicionar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbNomeExercicio);
            this.Controls.Add(this.lblNomeProfissional);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "CadastroItensLista";
            this.Text = "Criação Lista de Treino";
            this.Load += new System.EventHandler(this.CadastroItensLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblNomeCliente;
        private MetroFramework.Controls.MetroLabel lblNomeProfissional;
        private MetroFramework.Controls.MetroComboBox cmbNomeExercicio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton cmbAdicionar;
        private MetroFramework.Controls.MetroButton cmdConcluir;
    }
}