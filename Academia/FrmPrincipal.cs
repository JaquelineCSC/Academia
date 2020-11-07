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
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cmdCadastro_Click(object sender, EventArgs e)
        {
            cmdCadastro.BackColor = Color.Gray;
            cmdConsulta.BackColor = Color.Black;
            cmdCadastro.Enabled = false;
            cmdCliente.Visible = true;
            cmdExercicio.Visible = true;
            cmdProfissional.Visible = true;
            cmdAlimento.Visible = true;
            cmdCardapio.Visible = true;
            cmdListaExercicio.Visible = true;
        }

        private void cmdConsulta_Click(object sender, EventArgs e)
        {
            cmdConsulta.BackColor = Color.Gray;
            cmdCadastro.BackColor = Color.Black;
            cmdCadastro.Enabled = true;
            cmdCliente.Visible = false;
            cmdExercicio.Visible = false;
            cmdProfissional.Visible = false;
            cmdAlimento.Visible = false;
            cmdCardapio.Visible = false;
            cmdListaExercicio.Visible = false;

            FrmConsultaCliente F = new FrmConsultaCliente();
            F.ShowDialog();
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cliente = new FrmCadastroCliente();
            cliente.ShowDialog();
        }

        private void cmdExercicio_Click(object sender, EventArgs e)
        {
            FrmCadastroExercicio exercicio = new FrmCadastroExercicio();
            exercicio.ShowDialog();
        }

        private void cmdProfissional_Click(object sender, EventArgs e)
        {
            FrmCadastroProfissional profissional = new FrmCadastroProfissional();
            profissional.ShowDialog();
        }

        private void cmdAlimento_Click(object sender, EventArgs e)
        {
            FrmAlimento alimento = new FrmAlimento();
            alimento.ShowDialog();
        }

    }
}
