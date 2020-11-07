using MetroFramework.Controls;
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
    public partial class FrmCliente : MetroFramework.Forms.MetroForm
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        TCliente cliente = new TCliente();

        private void LimpaControle()
        {
            txtNome.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNumCasa.Text = "";
            metroDateTime1.Text = "";
            txtAvaliacao.Text = "";
            cmbNivel.Text = "";
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtNome.Text;
            cliente.Rua = txtRua.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.NumCasa = txtNumCasa.Text;
            cliente.DataNascimento = metroDateTime1.Text;
            cliente.AvaliacaoMedica = txtAvaliacao.Text;
            cliente.NivelConhecimento = cmbNivel.Text;
            cliente.DiaBaseVencimento = txtDiaVencimento.Text;

            MessageBox.Show("Incluido com Sucesso");
            LimpaControle();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtDiaVencimento.Text = DateTime.Today.Day.ToString();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtNome.Text;
            cliente.Rua = txtRua.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.NumCasa = txtNumCasa.Text;
            cliente.DataNascimento = metroDateTime1.Text;
            cliente.AvaliacaoMedica = txtAvaliacao.Text;
            cliente.NivelConhecimento = cmbNivel.Text;
            cliente.DiaBaseVencimento = txtDiaVencimento.Text;

            MessageBox.Show("Alterado com Sucesso");
            LimpaControle();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir ?", "Alerta", MessageBoxButtons.YesNo))
            {
                cliente.ExcluirDados();
            }
            LimpaControle();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            cmdInserir.Enabled = true;

            cmdAlterar.Enabled = false;
            cmdExcluir.Enabled = false;
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            cmdInserir.Enabled = false;
            cmdAlterar.Enabled = true;
            cmdExcluir.Enabled = true;

            FrmLocalizarCliente F = new FrmLocalizarCliente();
            F.ShowDialog();

            cliente.IdCliente = F.Id;
            cliente.ConsultarDados();

            txtNome.Text = cliente.NomeCliente;
            txtRua.Text = cliente.Rua;
            txtBairro.Text = cliente.Bairro;
            txtNumCasa.Text = cliente.NumCasa;
            metroDateTime1.Text = cliente.DataNascimento;
            txtAvaliacao.Text = cliente.AvaliacaoMedica;
            cmbNivel.Text = cliente.NivelConhecimento;
        }
    }
}
