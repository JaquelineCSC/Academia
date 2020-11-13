namespace Academia
{
    partial class FrmCadastroCardapio
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
            this.components = new System.ComponentModel.Container();
            this.lblProfissional = new MetroFramework.Controls.MetroLabel();
            this.lblDataHora = new MetroFramework.Controls.MetroLabel();
            this.lblAlimento = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtDataHora = new MetroFramework.Controls.MetroTextBox();
            this.cmbNome = new MetroFramework.Controls.MetroComboBox();
            this.cmbAlimento = new MetroFramework.Controls.MetroComboBox();
            this.cmbProfissional = new MetroFramework.Controls.MetroComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mbAdicionar = new MetroFramework.Controls.MetroButton();
            this.cmdSalvarCadsCardapio = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProfissional.Location = new System.Drawing.Point(194, 228);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(98, 25);
            this.lblProfissional.TabIndex = 54;
            this.lblProfissional.Text = "Profissional";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDataHora.Location = new System.Drawing.Point(194, 290);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(93, 25);
            this.lblDataHora.TabIndex = 53;
            this.lblDataHora.Text = "Data Hora:";
            // 
            // lblAlimento
            // 
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAlimento.Location = new System.Drawing.Point(194, 170);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(84, 25);
            this.lblAlimento.TabIndex = 52;
            this.lblAlimento.Text = "Alimento:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(194, 119);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 25);
            this.lblNome.TabIndex = 51;
            this.lblNome.Text = "Nome Cliente:";
            // 
            // txtDataHora
            // 
            // 
            // 
            // 
            this.txtDataHora.CustomButton.Image = null;
            this.txtDataHora.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txtDataHora.CustomButton.Name = "";
            this.txtDataHora.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtDataHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDataHora.CustomButton.TabIndex = 1;
            this.txtDataHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDataHora.CustomButton.UseSelectable = true;
            this.txtDataHora.CustomButton.Visible = false;
            this.txtDataHora.Enabled = false;
            this.txtDataHora.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDataHora.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtDataHora.Lines = new string[0];
            this.txtDataHora.Location = new System.Drawing.Point(431, 290);
            this.txtDataHora.MaxLength = 32767;
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.PasswordChar = '\0';
            this.txtDataHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataHora.SelectedText = "";
            this.txtDataHora.SelectionLength = 0;
            this.txtDataHora.SelectionStart = 0;
            this.txtDataHora.ShortcutsEnabled = true;
            this.txtDataHora.Size = new System.Drawing.Size(430, 30);
            this.txtDataHora.TabIndex = 50;
            this.txtDataHora.UseSelectable = true;
            this.txtDataHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDataHora.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbNome
            // 
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.ItemHeight = 23;
            this.cmbNome.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbNome.Location = new System.Drawing.Point(431, 115);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(430, 29);
            this.cmbNome.TabIndex = 55;
            this.cmbNome.UseSelectable = true;
            this.cmbNome.SelectedIndexChanged += new System.EventHandler(this.cmbNome_SelectedIndexChanged);
            // 
            // cmbAlimento
            // 
            this.cmbAlimento.FormattingEnabled = true;
            this.cmbAlimento.ItemHeight = 23;
            this.cmbAlimento.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbAlimento.Location = new System.Drawing.Point(431, 170);
            this.cmbAlimento.Name = "cmbAlimento";
            this.cmbAlimento.Size = new System.Drawing.Size(430, 29);
            this.cmbAlimento.TabIndex = 56;
            this.cmbAlimento.UseSelectable = true;
            this.cmbAlimento.SelectedIndexChanged += new System.EventHandler(this.cmbAlimento_SelectedIndexChanged);
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.ItemHeight = 23;
            this.cmbProfissional.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbProfissional.Location = new System.Drawing.Point(431, 228);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(430, 29);
            this.cmbProfissional.TabIndex = 57;
            this.cmbProfissional.UseSelectable = true;
            this.cmbProfissional.SelectedIndexChanged += new System.EventHandler(this.cmbProfissional_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(70, 350);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1016, 251);
            this.listBox1.TabIndex = 58;
            // 
            // mbAdicionar
            // 
            this.mbAdicionar.Location = new System.Drawing.Point(878, 170);
            this.mbAdicionar.Name = "mbAdicionar";
            this.mbAdicionar.Size = new System.Drawing.Size(91, 29);
            this.mbAdicionar.TabIndex = 59;
            this.mbAdicionar.Text = "Adicionar";
            this.mbAdicionar.UseSelectable = true;
            this.mbAdicionar.Click += new System.EventHandler(this.mbAdicionar_Click);
            // 
            // cmdSalvarCadsCardapio
            // 
            this.cmdSalvarCadsCardapio.Location = new System.Drawing.Point(1001, 607);
            this.cmdSalvarCadsCardapio.Name = "cmdSalvarCadsCardapio";
            this.cmdSalvarCadsCardapio.Size = new System.Drawing.Size(75, 23);
            this.cmdSalvarCadsCardapio.TabIndex = 60;
            this.cmdSalvarCadsCardapio.Text = "SALVAR";
            this.cmdSalvarCadsCardapio.UseSelectable = true;
            this.cmdSalvarCadsCardapio.Click += new System.EventHandler(this.cmdSalvarCadsCardapio_Click);
            // 
            // FrmCadastroCardapio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 854);
            this.Controls.Add(this.cmdSalvarCadsCardapio);
            this.Controls.Add(this.mbAdicionar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.cmbAlimento);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDataHora);
            this.Name = "FrmCadastroCardapio";
            this.Text = "Cardapio de alimentação";
            this.Load += new System.EventHandler(this.FrmCadastroCardapio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblProfissional;
        private MetroFramework.Controls.MetroLabel lblDataHora;
        private MetroFramework.Controls.MetroLabel lblAlimento;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtDataHora;
        private MetroFramework.Controls.MetroComboBox cmbNome;
        private MetroFramework.Controls.MetroComboBox cmbAlimento;
        private MetroFramework.Controls.MetroComboBox cmbProfissional;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton mbAdicionar;
        private MetroFramework.Controls.MetroButton cmdSalvarCadsCardapio;
    }
}