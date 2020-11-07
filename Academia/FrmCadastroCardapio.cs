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
    }
}
