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
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCriarTreino = new System.Windows.Forms.Button();
            this.cmdVoltarMenu = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.cmbProfissional.Location = new System.Drawing.Point(178, 138);
            this.cmbProfissional.Name = "cmbProfissional";
            this.cmbProfissional.Size = new System.Drawing.Size(327, 29);
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
            this.cmbNome.Location = new System.Drawing.Point(178, 84);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(327, 29);
            this.cmbNome.TabIndex = 65;
            this.cmbNome.UseSelectable = true;
            this.cmbNome.SelectedIndexChanged += new System.EventHandler(this.cmbNome_SelectedIndexChanged);
            // 
            // lblProfissional
            // 
            this.lblProfissional.AutoSize = true;
            this.lblProfissional.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProfissional.Location = new System.Drawing.Point(30, 138);
            this.lblProfissional.Name = "lblProfissional";
            this.lblProfissional.Size = new System.Drawing.Size(98, 25);
            this.lblProfissional.TabIndex = 64;
            this.lblProfissional.Text = "Profissional";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(30, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 25);
            this.lblNome.TabIndex = 61;
            this.lblNome.Text = "Nome Cliente:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.cmdSalvar);
            this.panel1.Controls.Add(this.cmdCriarTreino);
            this.panel1.Controls.Add(this.cmdVoltarMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 72);
            this.panel1.TabIndex = 71;
            // 
            // cmdCriarTreino
            // 
            this.cmdCriarTreino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdCriarTreino.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdCriarTreino.FlatAppearance.BorderSize = 0;
            this.cmdCriarTreino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdCriarTreino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdCriarTreino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCriarTreino.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCriarTreino.ForeColor = System.Drawing.Color.White;
            this.cmdCriarTreino.Location = new System.Drawing.Point(166, 0);
            this.cmdCriarTreino.Name = "cmdCriarTreino";
            this.cmdCriarTreino.Size = new System.Drawing.Size(157, 72);
            this.cmdCriarTreino.TabIndex = 22;
            this.cmdCriarTreino.Text = "Criar Treino";
            this.cmdCriarTreino.UseVisualStyleBackColor = false;
            this.cmdCriarTreino.Click += new System.EventHandler(this.cmdCriarTreino_Click);
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
            this.cmdVoltarMenu.Location = new System.Drawing.Point(343, 0);
            this.cmdVoltarMenu.Name = "cmdVoltarMenu";
            this.cmdVoltarMenu.Size = new System.Drawing.Size(157, 72);
            this.cmdVoltarMenu.TabIndex = 21;
            this.cmdVoltarMenu.Text = "Voltar Menu";
            this.cmdVoltarMenu.UseVisualStyleBackColor = false;
            this.cmdVoltarMenu.Click += new System.EventHandler(this.cmdVoltarMenu_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSalvar.FlatAppearance.BorderSize = 0;
            this.cmdSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalvar.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalvar.ForeColor = System.Drawing.Color.White;
            this.cmdSalvar.Location = new System.Drawing.Point(3, 0);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(157, 72);
            this.cmdSalvar.TabIndex = 23;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // FrmCadastroListaTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbProfissional);
            this.Controls.Add(this.cmbNome);
            this.Controls.Add(this.lblProfissional);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCadastroListaTreino";
            this.Text = "Lista Treino";
            this.Load += new System.EventHandler(this.FrmListaTreino_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbProfissional;
        private MetroFramework.Controls.MetroComboBox cmbNome;
        private MetroFramework.Controls.MetroLabel lblProfissional;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCriarTreino;
        private System.Windows.Forms.Button cmdVoltarMenu;
        private System.Windows.Forms.Button cmdSalvar;
    }
}