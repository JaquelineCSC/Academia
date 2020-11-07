namespace Academia
{
    partial class FrmAlimento
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
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtCalorias = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdVoltarMenu = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdInserir = new System.Windows.Forms.Button();
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNome.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(232, 177);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(430, 30);
            this.txtNome.TabIndex = 43;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(68, 177);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // txtCalorias
            // 
            // 
            // 
            // 
            this.txtCalorias.CustomButton.Image = null;
            this.txtCalorias.CustomButton.Location = new System.Drawing.Point(402, 2);
            this.txtCalorias.CustomButton.Name = "";
            this.txtCalorias.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCalorias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCalorias.CustomButton.TabIndex = 1;
            this.txtCalorias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCalorias.CustomButton.UseSelectable = true;
            this.txtCalorias.CustomButton.Visible = false;
            this.txtCalorias.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCalorias.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtCalorias.Lines = new string[0];
            this.txtCalorias.Location = new System.Drawing.Point(232, 256);
            this.txtCalorias.MaxLength = 32767;
            this.txtCalorias.Name = "txtCalorias";
            this.txtCalorias.PasswordChar = '\0';
            this.txtCalorias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCalorias.SelectedText = "";
            this.txtCalorias.SelectionLength = 0;
            this.txtCalorias.SelectionStart = 0;
            this.txtCalorias.ShortcutsEnabled = true;
            this.txtCalorias.Size = new System.Drawing.Size(430, 30);
            this.txtCalorias.TabIndex = 45;
            this.txtCalorias.UseSelectable = true;
            this.txtCalorias.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCalorias.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(68, 256);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "Calorias:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.cmdExcluir);
            this.panel1.Controls.Add(this.cmdVoltarMenu);
            this.panel1.Controls.Add(this.cmdNovo);
            this.panel1.Controls.Add(this.cmdInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 72);
            this.panel1.TabIndex = 46;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdExcluir.Enabled = false;
            this.cmdExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdExcluir.FlatAppearance.BorderSize = 0;
            this.cmdExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcluir.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.ForeColor = System.Drawing.Color.White;
            this.cmdExcluir.Location = new System.Drawing.Point(387, 0);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(114, 72);
            this.cmdExcluir.TabIndex = 23;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
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
            this.cmdVoltarMenu.Location = new System.Drawing.Point(577, 0);
            this.cmdVoltarMenu.Name = "cmdVoltarMenu";
            this.cmdVoltarMenu.Size = new System.Drawing.Size(139, 72);
            this.cmdVoltarMenu.TabIndex = 21;
            this.cmdVoltarMenu.Text = "Voltar Menu";
            this.cmdVoltarMenu.UseVisualStyleBackColor = false;
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdNovo.FlatAppearance.BorderSize = 0;
            this.cmdNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNovo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNovo.ForeColor = System.Drawing.Color.White;
            this.cmdNovo.Location = new System.Drawing.Point(34, 0);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(112, 72);
            this.cmdNovo.TabIndex = 19;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.UseVisualStyleBackColor = false;
            this.cmdNovo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // cmdInserir
            // 
            this.cmdInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdInserir.Enabled = false;
            this.cmdInserir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdInserir.FlatAppearance.BorderSize = 0;
            this.cmdInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInserir.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInserir.ForeColor = System.Drawing.Color.White;
            this.cmdInserir.Location = new System.Drawing.Point(212, 0);
            this.cmdInserir.Name = "cmdInserir";
            this.cmdInserir.Size = new System.Drawing.Size(118, 72);
            this.cmdInserir.TabIndex = 18;
            this.cmdInserir.Text = "Salvar";
            this.cmdInserir.UseVisualStyleBackColor = false;
            this.cmdInserir.Click += new System.EventHandler(this.cmdInserir_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(360, 108);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(161, 51);
            this.cmdPesquisar.TabIndex = 47;
            this.cmdPesquisar.Text = "Localizar Alimento";
            this.cmdPesquisar.UseSelectable = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 550);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCalorias);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmAlimento";
            this.Text = "Cadastro Alimento";
            this.Load += new System.EventHandler(this.FrmAlimento_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroTextBox txtCalorias;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdVoltarMenu;
        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.Button cmdInserir;
        private MetroFramework.Controls.MetroButton cmdPesquisar;
    }
}