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
            this.cmdExcluir = new MetroFramework.Controls.MetroButton();
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cmdLimpar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeCliente.Location = new System.Drawing.Point(111, 80);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(64, 25);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.AutoSize = true;
            this.lblNomeProfissional.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeProfissional.Location = new System.Drawing.Point(448, 80);
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
            this.cmbNomeExercicio.Size = new System.Drawing.Size(596, 29);
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
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(23, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 364);
            this.listBox1.TabIndex = 4;
            // 
            // cmbAdicionar
            // 
            this.cmbAdicionar.Location = new System.Drawing.Point(635, 176);
            this.cmbAdicionar.Name = "cmbAdicionar";
            this.cmbAdicionar.Size = new System.Drawing.Size(110, 41);
            this.cmbAdicionar.TabIndex = 5;
            this.cmbAdicionar.Text = "Adicionar Exercicio";
            this.cmbAdicionar.UseSelectable = true;
            this.cmbAdicionar.Click += new System.EventHandler(this.cmbAdicionar_Click);
            // 
            // cmdConcluir
            // 
            this.cmdConcluir.Location = new System.Drawing.Point(613, 495);
            this.cmdConcluir.Name = "cmdConcluir";
            this.cmdConcluir.Size = new System.Drawing.Size(148, 45);
            this.cmdConcluir.TabIndex = 6;
            this.cmdConcluir.Text = "Concluir";
            this.cmdConcluir.UseSelectable = true;
            this.cmdConcluir.Click += new System.EventHandler(this.cmdConcluir_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(635, 241);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(110, 40);
            this.cmdExcluir.TabIndex = 7;
            this.cmdExcluir.Text = "Excluir Exercicio";
            this.cmdExcluir.UseSelectable = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(624, 41);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(149, 64);
            this.cmdPesquisar.TabIndex = 8;
            this.cmdPesquisar.Text = "Modificar um Treino";
            this.cmdPesquisar.UseSelectable = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(344, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Profissional:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(37, 80);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 25);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Cliente:";
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(635, 311);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(110, 40);
            this.cmdLimpar.TabIndex = 11;
            this.cmdLimpar.Text = "Limpar Exercicios";
            this.cmdLimpar.UseSelectable = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // FrmCadastroItensLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 600);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdConcluir);
            this.Controls.Add(this.cmbAdicionar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbNomeExercicio);
            this.Controls.Add(this.lblNomeProfissional);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "FrmCadastroItensLista";
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
        private MetroFramework.Controls.MetroButton cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton cmdLimpar;
    }
}