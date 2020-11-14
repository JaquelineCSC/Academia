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
    public partial class FrmCadastroMensalidade : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroMensalidade()
        {
            InitializeComponent();
        }

        TMensalidade mensalidade = new TMensalidade();
        TCliente cliente = new TCliente();

        private void FrmCadastroMensalidade_Load(object sender, EventArgs e)
        {
            cmbNome.DisplayMember = "NomeCliente";
            cmbNome.ValueMember = "idCliente";
            cmbNome.DataSource = cliente.ListarDados().Tables[0];
        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPagar_Click(object sender, EventArgs e)
        {
            mensalidade.IdCliente = cliente.IdCliente;
            mensalidade.DataPagamento = metroDateTime1.Value.ToString("yyyy/MM/dd");
            mensalidade.MesPagamento = cmbMesPagamento.Text;
            mensalidade.Valor1 = int.Parse(txtValor.Text);
            mensalidade.IncluirDados();
            MessageBox.Show("Pagamento Efetuado com Sucesso !! ");
            cmbNome.Text = "";
            cmbMesPagamento.Text = "";
            txtValor.Text = "";
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente.IdCliente = int.Parse(cmbNome.SelectedValue.ToString());
        }

        private void txtValor_Click(object sender, EventArgs e)
        {

        }
    }
}
