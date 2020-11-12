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
    public partial class FrmCadastroItensLista : MetroFramework.Forms.MetroForm
    {
        public int id;
        public FrmCadastroItensLista(int id)
        {
            InitializeComponent();
            this.id = id;

            treino.IdLista = this.id;
            treino.ConsultarDados();

            lblNomeCliente.Text = treino.NomeCliente;
            lblNomeProfissional.Text = treino.NomeProfissional;

            treino.ConsultarDadosSimples();
        }

        TItensLista itensLista = new TItensLista();
        TExercicio exercicio = new TExercicio();
        TListaTreino treino = new TListaTreino();

        int[] vetor = new int[20];
        int cont = 0;

        private void CadastroItensLista_Load(object sender, EventArgs e)
        {
            cmbNomeExercicio.DisplayMember = "NomeExercicio";
            cmbNomeExercicio.ValueMember = "idExercicio";
            cmbNomeExercicio.DataSource = exercicio.ListarDados().Tables[0];
        }

        private void cmbAdicionar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cmbNomeExercicio.Text);
            vetor[cont] = int.Parse(cmbNomeExercicio.SelectedValue.ToString());
            cont++;
        }

        private void cmdConcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cont; i++)
            {
                itensLista.IdLista = treino.IdLista;
                itensLista.IdExercicio = vetor[i];
                itensLista.IncluirDados();
            }
            MessageBox.Show("Lista de Treino criada com sucesso");
            Close();
        }
    }
}
