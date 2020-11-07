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
    public partial class FrmCadastroCliente : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        TCliente cliente = new TCliente();

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtNome.Text;
            cliente.Rua = txtRua.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.NumCasa = txtNumero.Text;
            cliente.DataNascimento = metroDateTime1.Value.ToString("yyyy/MM/dd");
            cliente.AvaliacaoMedica = txtAvaliacao.Text;
            cliente.DiaBaseVencimento = txtDiaVencimento.Text;
            cliente.NivelConhecimento = cmbConhecimento.Text;

            cliente.IncluirDados();
            MessageBox.Show("Cliente cadastrado com Sucesso !");
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            if (int.Parse(DateTime.Today.Day.ToString()) < 10)
                txtDiaVencimento.Text = "0" + DateTime.Today.Day.ToString();
            else
                txtDiaVencimento.Text = DateTime.Today.Day.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Novo_Click(object sender, EventArgs e)
        {

        }
    }
}
