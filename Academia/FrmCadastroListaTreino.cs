﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class FrmCadastroListaTreino : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroListaTreino()
        {
            InitializeComponent();
        }
        
        TListaTreino treinos = new TListaTreino();
        TExercicio exercicio = new TExercicio();
        TCliente cliente = new TCliente();
        TProfissional profissional = new TProfissional();

        private void FrmListaTreino_Load(object sender, EventArgs e)
        {
            cmbNome.DisplayMember = "NomeCliente";
            cmbNome.ValueMember = "idCliente";
            cmbNome.DataSource = cliente.ListarDados().Tables[0];

            cmbProfissional.DisplayMember = "NomeProfissional";
            cmbProfissional.ValueMember = "idProfissional";
            cmbProfissional.DataSource = profissional.ListarDados().Tables[0];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            treinos.IdCliente = int.Parse(cmbNome.SelectedValue.ToString());
        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            treinos.IdProfissional = int.Parse(cmbProfissional.SelectedValue.ToString());
        }
        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            treinos.DataTreino = DateTime.Now.ToString();
            treinos.IncluirDados();

            MessageBox.Show("Treinos Cadastrados com Sucesso !");
        }

        private void cmdCriarTreino_Click(object sender, EventArgs e)
        {
            FrmSelecaoLista frmSelecao = new FrmSelecaoLista();
            frmSelecao.ShowDialog();
        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
