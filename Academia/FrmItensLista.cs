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
    public partial class FrmItensLista : MetroFramework.Forms.MetroForm
    {
        public FrmItensLista()
        {
            InitializeComponent();
        }
        public int aux = 0;
        TItensLista itens = new TItensLista();
        TExercicio exercicios = new TExercicio();
        TCliente clientes = new TCliente();
        TListaTreino listas = new TListaTreino();
        private void FrmItensLista_Load(object sender, EventArgs e)
        {
           cmbExercicios.DisplayMember = "NomeExercicio";
            cmbExercicios.ValueMember = "idExercicio";
            cmbExercicios.DataSource = exercicios.ListarDados().Tables[0];

            cmbCliente.DisplayMember = "NomeCliente";
            cmbCliente.ValueMember = "idCliente";
            cmbCliente.DataSource = clientes.ListarDados().Tables[0];
        }

        private void mbAdicionar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cmbExercicios.Text);
        }

        private void cmbExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            itens.IdExercicio = int.Parse(cmbExercicios.SelectedValue.ToString());
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            aux = int.Parse(cmbCliente.SelectedValue.ToString());
        }

        private void cmdSalvarItens_Click(object sender, EventArgs e)
        {
            // aqui devemos encontrar o ID do cliente "aux" dentro da tabela ListaTreinos no campo IDcliente
            // com isso obter o campo idLista ligado ao respectivo id cliente


            // aqui foi feito o teste para ver os valores que estavam sendo OBTIDOS.
            //referente ao AUX, que no caso e IDcliente...esta funcionando, ja testamos.
            // so falta receber o ID da lista, referente a tal CLIENTE.


            //while (listas.IdCliente != aux)
            //{
            //    MessageBox.Show(listas.IdCliente.ToString() + "Listas id cliente");
            //    MessageBox.Show(aux.ToString() + "vARIAVEL AUX");
            //    MessageBox.Show("Encontrou !");
            
            // itens.IncluirDados();
        }
    }
}
