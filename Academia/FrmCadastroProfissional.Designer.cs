namespace Academia
{
    partial class FrmCadastroProfissional
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
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdVoltarMenu = new System.Windows.Forms.Button();
            this.cmdNovo = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(324, 2);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtValor.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(263, 155);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.Size = new System.Drawing.Size(352, 30);
            this.txtValor.TabIndex = 16;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(324, 2);
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
            this.txtNome.Location = new System.Drawing.Point(263, 99);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(352, 30);
            this.txtNome.TabIndex = 15;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(145, 155);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 25);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Valor serviço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(145, 99);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.cmdExcluir);
            this.panel1.Controls.Add(this.cmdVoltarMenu);
            this.panel1.Controls.Add(this.cmdNovo);
            this.panel1.Controls.Add(this.cmdSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 72);
            this.panel1.TabIndex = 21;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.cmdExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdExcluir.FlatAppearance.BorderSize = 0;
            this.cmdExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcluir.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcluir.ForeColor = System.Drawing.Color.White;
            this.cmdExcluir.Location = new System.Drawing.Point(431, 0);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(147, 72);
            this.cmdExcluir.TabIndex = 22;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = false;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdVoltarMenu
            // 
            this.cmdVoltarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.cmdVoltarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdVoltarMenu.FlatAppearance.BorderSize = 0;
            this.cmdVoltarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdVoltarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVoltarMenu.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltarMenu.ForeColor = System.Drawing.Color.White;
            this.cmdVoltarMenu.Location = new System.Drawing.Point(614, 0);
            this.cmdVoltarMenu.Name = "cmdVoltarMenu";
            this.cmdVoltarMenu.Size = new System.Drawing.Size(157, 72);
            this.cmdVoltarMenu.TabIndex = 21;
            this.cmdVoltarMenu.Text = "Voltar Menu";
            this.cmdVoltarMenu.UseVisualStyleBackColor = false;
            this.cmdVoltarMenu.Click += new System.EventHandler(this.cmdVoltarMenu_Click);
            // 
            // cmdNovo
            // 
            this.cmdNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.cmdNovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdNovo.FlatAppearance.BorderSize = 0;
            this.cmdNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdNovo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNovo.ForeColor = System.Drawing.Color.White;
            this.cmdNovo.Location = new System.Drawing.Point(55, 0);
            this.cmdNovo.Name = "cmdNovo";
            this.cmdNovo.Size = new System.Drawing.Size(147, 72);
            this.cmdNovo.TabIndex = 19;
            this.cmdNovo.Text = "Novo";
            this.cmdNovo.UseVisualStyleBackColor = false;
            this.cmdNovo.Click += new System.EventHandler(this.cmdNovo_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(129)))), ((int)(((byte)(33)))));
            this.cmdSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSalvar.FlatAppearance.BorderSize = 0;
            this.cmdSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalvar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalvar.ForeColor = System.Drawing.Color.White;
            this.cmdSalvar.Location = new System.Drawing.Point(243, 0);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(147, 72);
            this.cmdSalvar.TabIndex = 18;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdInserir_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(634, 119);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(161, 51);
            this.cmdPesquisar.TabIndex = 48;
            this.cmdPesquisar.Text = "Localizar Profissional";
            this.cmdPesquisar.UseSelectable = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 270);
            this.panel2.TabIndex = 49;
            // 
            // FrmCadastroProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 332);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCadastroProfissional";
            this.Text = "Cadastrar Profissional";
            this.Load += new System.EventHandler(this.FrmCadastroProfissional_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdNovo;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Button cmdVoltarMenu;
        private System.Windows.Forms.Button cmdExcluir;
        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private System.Windows.Forms.Panel panel2;
    }
}