namespace Academia
{
    partial class FrmCadastroListaTreino
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
            this.cmbProfissional = new MetroFramework.Controls.MetroComboBox();
            this.cmbNome = new MetroFramework.Controls.MetroComboBox();
            this.lblProfissional = new MetroFramework.Controls.MetroLabel();
            this.lblDataHora = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtDataHora = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mbAdicionar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbProfissional
            // 
            this.cmbProfissional.FormattingEnabled = true;
            this.cmbProfissional.ItemHeight = 23;
            this.cmbProfissional.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbProfissional.Location = new System.Drawing.Point(418, 134);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(430, 29);
            this.cmbProfissional.TabIndex = 67;
            this.cmbProfissional.UseSelectable = true;
            this.cmbProfissional.SelectedIndexChanged += new System.EventHandler(this.cmbProfissional_SelectedIndexChanged);
            // 
            // cmbNome
            // 
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.ItemHeight = 23;
            this.cmbNome.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbNome.Location = new System.Drawing.Point(418, 80);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(430, 29);
            this.cmbNome.TabIndex = 65;
            this.cmbNome.UseSelectable = true;
            this.cmbNome.SelectedIndexChanged += new System.EventHandler(this.cmbNome_SelectedIndexChanged);
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProfissional.Location = new System.Drawing.Point(181, 134);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(98, 25);
            this.lblProfissional.TabIndex = 64;
            this.lblProfissional.Text = "Profissional";
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDataHora.Location = new System.Drawing.Point(181, 196);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(93, 25);
            this.lblDataHora.TabIndex = 63;
            this.lblDataHora.Text = "Data Hora:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(181, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 25);
            this.lblNome.TabIndex = 61;
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
            this.txtDataHora.Location = new System.Drawing.Point(418, 196);
            this.txtDataHora.MaxLength = 32767;
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.PasswordChar = '\0';
            this.txtDataHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataHora.SelectedText = "";
            this.txtDataHora.SelectionLength = 0;
            this.txtDataHora.SelectionStart = 0;
            this.txtDataHora.ShortcutsEnabled = true;
            this.txtDataHora.Size = new System.Drawing.Size(430, 30);
            this.txtDataHora.TabIndex = 60;
            this.txtDataHora.UseSelectable = true;
            this.txtDataHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDataHora.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mbAdicionar
            // 
            this.mbAdicionar.Location = new System.Drawing.Point(757, 244);
            this.mbAdicionar.Name = "mbAdicionar";
            this.mbAdicionar.Size = new System.Drawing.Size(91, 29);
            this.mbAdicionar.TabIndex = 69;
            this.mbAdicionar.Text = "Adicionar";
            this.mbAdicionar.UseSelectable = true;
            this.mbAdicionar.Click += new System.EventHandler(this.mbAdicionar_Click);
            // 
            // FrmCadastroListaTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 322);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDataHora);
            this.Controls.Add(this.mbAdicionar);
            this.Name = "FrmCadastroListaTreino";
            this.Text = "Lista Treino";
            this.Load += new System.EventHandler(this.FrmListaTreino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbProfissional;
        private MetroFramework.Controls.MetroComboBox cmbNome;
        private MetroFramework.Controls.MetroLabel lblProfissional;
        private MetroFramework.Controls.MetroLabel lblDataHora;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtDataHora;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton mbAdicionar;
    }
}