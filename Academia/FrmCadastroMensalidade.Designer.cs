namespace Academia
{
    partial class FrmCadastroMensalidade
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
            this.cmbNome = new MetroFramework.Controls.MetroComboBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbMesPagamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdVoltarMenu = new System.Windows.Forms.Button();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNome
            // 
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.ItemHeight = 23;
            this.cmbNome.Items.AddRange(new object[] {
            "Iniciante",
            "Intermediário",
            "Avançado"});
            this.cmbNome.Location = new System.Drawing.Point(159, 90);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(430, 29);
            this.cmbNome.TabIndex = 57;
            this.cmbNome.UseSelectable = true;
            this.cmbNome.SelectedIndexChanged += new System.EventHandler(this.cmbNome_SelectedIndexChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(33, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 25);
            this.lblNome.TabIndex = 56;
            this.lblNome.Text = "Nome Cliente:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(33, 153);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(147, 25);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Data Pagamento :";
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(186, 275);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(259, 23);
            this.txtValor.TabIndex = 62;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(33, 273);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(150, 25);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Valor Pagamento :";
            // 
            // cmbMesPagamento
            // 
            this.cmbMesPagamento.FormattingEnabled = true;
            this.cmbMesPagamento.ItemHeight = 23;
            this.cmbMesPagamento.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbMesPagamento.Location = new System.Drawing.Point(186, 211);
            this.cmbMesPagamento.Name = "cmbMesPagamento";
            this.cmbMesPagamento.Size = new System.Drawing.Size(183, 29);
            this.cmbMesPagamento.TabIndex = 63;
            this.cmbMesPagamento.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(33, 215);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 25);
            this.metroLabel3.TabIndex = 64;
            this.metroLabel3.Text = "Mês Pagamento :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.cmdVoltarMenu);
            this.panel1.Controls.Add(this.cmdPagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 72);
            this.panel1.TabIndex = 65;
            // 
            // cmdVoltarMenu
            // 
            this.cmdVoltarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdVoltarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdVoltarMenu.FlatAppearance.BorderSize = 0;
            this.cmdVoltarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdVoltarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVoltarMenu.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltarMenu.ForeColor = System.Drawing.Color.White;
            this.cmdVoltarMenu.Location = new System.Drawing.Point(363, 0);
            this.cmdVoltarMenu.Name = "cmdVoltarMenu";
            this.cmdVoltarMenu.Size = new System.Drawing.Size(157, 72);
            this.cmdVoltarMenu.TabIndex = 21;
            this.cmdVoltarMenu.Text = "Voltar Menu";
            this.cmdVoltarMenu.UseVisualStyleBackColor = false;
            this.cmdVoltarMenu.Click += new System.EventHandler(this.cmdVoltarMenu_Click);
            // 
            // cmdPagar
            // 
            this.cmdPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdPagar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdPagar.FlatAppearance.BorderSize = 0;
            this.cmdPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPagar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPagar.ForeColor = System.Drawing.Color.White;
            this.cmdPagar.Location = new System.Drawing.Point(87, 0);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(147, 72);
            this.cmdPagar.TabIndex = 18;
            this.cmdPagar.Text = "Pagar";
            this.cmdPagar.UseVisualStyleBackColor = false;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(186, 153);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(245, 29);
            this.metroDateTime1.TabIndex = 66;
            // 
            // FrmCadastroMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 492);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbMesPagamento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastroMensalidade";
            this.Text = "FrmCadastroMensalidade";
            this.Load += new System.EventHandler(this.FrmCadastroMensalidade_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbNome;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbMesPagamento;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdVoltarMenu;
        private System.Windows.Forms.Button cmdPagar;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}