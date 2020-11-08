using System;
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
        List<TListaTreino> ListTraining = new List<TListaTreino>();
        private void FrmListaTreino_Load(object sender, EventArgs e)
        {
                cmbNome.DisplayMember = "NomeCliente";
                cmbNome.ValueMember = "idCliente";
                cmbNome.DataSource = cliente.ListarDados().Tables[0];

                cmbProfissional.DisplayMember = "NomeProfissional";
                cmbProfissional.ValueMember = "idProfissional";
                cmbProfissional.DataSource = profissional.ListarDados().Tables[0];

                cmbExercicios.DisplayMember = "NomeExercicio";
                cmbExercicios.ValueMember = "idExercicio";
                cmbExercicios.DataSource = exercicio.ListarDados().Tables[0];
        }

        private void mbAdicionar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cmbExercicios.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDataHora.Text = DateTime.Now.ToString();
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            treinos.IdCliente = int.Parse(cmbNome.SelectedValue.ToString());
        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            treinos.IdProfissional = int.Parse(cmbProfissional.SelectedValue.ToString());
        }

        private void txtDataHora_Click(object sender, EventArgs e)
        {
            treinos.DataTreino = txtDataHora.Text;
        }

        private void cmbExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
           //treinos
        }
    }
}
