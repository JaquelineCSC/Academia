﻿namespace Academia
{
    partial class FrmCadastroExercicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Novo = new System.Windows.Forms.Button();
            this.cmdInserir = new System.Windows.Forms.Button();
            this.cmbRegiao = new MetroFramework.Controls.MetroComboBox();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lblRegiao = new MetroFramework.Controls.MetroLabel();
            this.lblNivel = new MetroFramework.Controls.MetroLabel();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.cmbNivel = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.Novo);
            this.panel1.Controls.Add(this.cmdInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 72);
            this.panel1.TabIndex = 22;
            // 
            // Novo
            // 
            this.Novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Novo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Novo.FlatAppearance.BorderSize = 0;
            this.Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Novo.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Novo.ForeColor = System.Drawing.Color.White;
            this.Novo.Location = new System.Drawing.Point(86, 0);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(147, 72);
            this.Novo.TabIndex = 19;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = false;
            // 
            // cmdInserir
            // 
            this.cmdInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.cmdInserir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdInserir.FlatAppearance.BorderSize = 0;
            this.cmdInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.cmdInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.cmdInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInserir.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInserir.ForeColor = System.Drawing.Color.White;
            this.cmdInserir.Location = new System.Drawing.Point(282, 0);
            this.cmdInserir.Name = "cmdInserir";
            this.cmdInserir.Size = new System.Drawing.Size(147, 72);
            this.cmdInserir.TabIndex = 18;
            this.cmdInserir.Text = "Inserir";
            this.cmdInserir.UseVisualStyleBackColor = false;
            this.cmdInserir.Click += new System.EventHandler(this.cmdInserir_Click);
            // 
            // cmbRegiao
            // 
            this.cmbRegiao.FormattingEnabled = true;
            this.cmbRegiao.ItemHeight = 23;
            this.cmbRegiao.Location = new System.Drawing.Point(364, 336);
            this.cmbRegiao.Name = "cmbRegiao";
            this.cmbRegiao.Size = new System.Drawing.Size(430, 29);
            this.cmbRegiao.TabIndex = 37;
            this.cmbRegiao.UseSelectable = true;
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescricao.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(364, 158);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(430, 90);
            this.txtDescricao.TabIndex = 35;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtNome.Location = new System.Drawing.Point(364, 102);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(430, 30);
            this.txtNome.TabIndex = 31;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblRegiao
            // 
            this.lblRegiao.AutoSize = true;
            this.lblRegiao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRegiao.Location = new System.Drawing.Point(157, 336);
            this.lblRegiao.Name = "lblRegiao";
            this.lblRegiao.Size = new System.Drawing.Size(139, 25);
            this.lblRegiao.TabIndex = 26;
            this.lblRegiao.Text = "Região Exercício:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNivel.Location = new System.Drawing.Point(157, 283);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(125, 25);
            this.lblNivel.TabIndex = 25;
            this.lblNivel.Text = "Nível Exercício:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescricao.Location = new System.Drawing.Point(157, 158);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(156, 25);
            this.lblDescricao.TabIndex = 24;
            this.lblDescricao.Text = "Descrição Exercício";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(157, 102);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(134, 25);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome Exercicio:";
            // 
            // cmbNivel
            // 
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.ItemHeight = 23;
            this.cmbNivel.Location = new System.Drawing.Point(364, 283);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(430, 29);
            this.cmbNivel.TabIndex = 38;
            this.cmbNivel.UseSelectable = true;
            // 
            // FrmCadastroExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 556);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbRegiao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblRegiao);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCadastroExercicio";
            this.Text = "Cadastro Exercicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button cmdInserir;
        private MetroFramework.Controls.MetroComboBox cmbRegiao;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroLabel lblRegiao;
        private MetroFramework.Controls.MetroLabel lblNivel;
        private MetroFramework.Controls.MetroLabel lblDescricao;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroComboBox cmbNivel;
    }
}