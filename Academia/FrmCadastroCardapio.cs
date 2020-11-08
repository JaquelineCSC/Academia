using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class FrmCadastroCardapio : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroCardapio()
        {
            InitializeComponent();
        }

        TCardapio cardapio = new TCardapio();
        TCliente cliente = new TCliente();
        TProfissional profissional = new TProfissional();
        TAlimento alimento = new TAlimento();
        List<TAlimento> listaAlimento = new List<TAlimento>();
        public int contaralimentos = 0;
        public int[] vetoralimentos = new int[20];
        private void FrmCadastroCardapio_Load(object sender, EventArgs e)
        {
            cmbNome.DisplayMember = "NomeCliente";
            cmbNome.ValueMember = "idCliente";
            cmbNome.DataSource = cliente.ListarDados().Tables[0];

            cmbProfissional.DisplayMember = "NomeProfissional";
            cmbProfissional.ValueMember = "idProfissional";
            cmbProfissional.DataSource = profissional.ListarDados().Tables[0];

            cmbAlimento.DisplayMember = "NomeAlimento";
            cmbAlimento.ValueMember = "idAlimento";
            cmbAlimento.DataSource = alimento.ListarDados().Tables[0];

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDataHora.Text = DateTime.Now.ToString();
        }


        

        private void mbAdicionar_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(cmbAlimento.Text);
            vetoralimentos[contaralimentos] = cardapio.IdAlimento;
            contaralimentos++;
        }

        private void cmdSalvarCadsCardapio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < contaralimentos; i++) { 
            cardapio.DataHora = txtDataHora.Text;
                cardapio.IdAlimento = vetoralimentos[i];
            cardapio.IncluirDados();
            }
            MessageBox.Show(" Cardapio Realizado com Sucesso !");
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardapio.IdCliente = int.Parse(cmbNome.SelectedValue.ToString());
        }

        private void cmbAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardapio.IdAlimento = int.Parse(cmbAlimento.SelectedValue.ToString());
        }

        private void cmbProfissional_SelectedIndexChanged(object sender, EventArgs e)
        {
            cardapio.IdProfissional = int.Parse(cmbProfissional.SelectedValue.ToString());
        }
    }
}
