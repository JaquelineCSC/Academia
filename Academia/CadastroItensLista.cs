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
    public partial class CadastroItensLista : MetroFramework.Forms.MetroForm
    {
        public CadastroItensLista()
        {
            InitializeComponent();
            lblNomeCliente.Text = Convert.ToString(this.Treino.ListarDadosNomeCliente());
            lblNomeProfissional.Text = Convert.ToString(this.Treino.ListarDadosNomeProfissional());
        }

        TItensLista itensLista = new TItensLista();
        TExercicio exercicio = new TExercicio();
        TListaTreino treino = new TListaTreino();

        int[] vetor = new int[20];
        int cont = 0;

        public TListaTreino Treino { get => treino; set => treino = value; }

        private void CadastroItensLista_Load(object sender, EventArgs e)
        {
            cmbNomeExercicio.DisplayMember = "NomeExercicio";
            cmbNomeExercicio.ValueMember = "idExercicio";
            cmbNomeExercicio.DataSource = exercicio.ListarDados().Tables[0];
        }

        private void cmbAdicionar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cmbNomeExercicio.Text);
            vetor[cont] = exercicio.IdExercicio;
            cont++;
        }

        private void cmdConcluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cont; i++)
            {
                itensLista.IdLista = Treino.IdLista;
                itensLista.IdExercicio = vetor[i];
                itensLista.IncluirDados();
            }
            MessageBox.Show("Lista de Treino criada com sucesso");
            Close();
        }
    }
}
