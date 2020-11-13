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
    public partial class FrmCadastroCliente : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroCliente()
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

        private void ON()
        {
            txtNome.Enabled = true;
            txtRua.Enabled = true;
            txtBairro.Enabled = true;
            txtNumCasa.Enabled = true;
            metroDateTime1.Enabled = true;
            txtAvaliacao.Enabled = true;
            cmbNivel.Enabled = true;
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtNome.Text;
            cliente.Rua = txtRua.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.NumCasa = txtNumCasa.Text;
            cliente.DataNascimento = metroDateTime1.Value.ToString("yyyy/MM/dd");
            cliente.AvaliacaoMedica = txtAvaliacao.Text;
            cliente.NivelConhecimento = cmbNivel.Text;
            cliente.DiaBaseVencimento = txtDiaVencimento.Text;

            cliente.IncluirDados();
            MessageBox.Show("Incluido com Sucesso");
            LimpaControle();

            cmdNovo.Enabled = true;
            cmdInserir.Enabled = false;
            cmdPesquisar.Enabled = true;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            int x = int.Parse(DateTime.Today.Day.ToString());
            if (x < 10)
                txtDiaVencimento.Text = "0" + x.ToString();
            else
                txtDiaVencimento.Text = x.ToString();
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

            cmdAlterar.Enabled = false;
            cmdNovo.Enabled = true;
            cmdPesquisar.Enabled = true;
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja realmente excluir ?", "Alerta", MessageBoxButtons.YesNo))
            {
                cliente.ExcluirDados();
            }
            LimpaControle();

            cmdExcluir.Enabled = false;
            cmdNovo.Enabled = true;
            cmdPesquisar.Enabled = true;
        }

        private void cmdNovo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            cmdNovo.Enabled = false;
            cmdInserir.Enabled = true;

            cmdAlterar.Enabled = false;
            cmdExcluir.Enabled = false;
            ON();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            ON();
            cmdInserir.Enabled = false;
            cmdAlterar.Enabled = true;
            cmdExcluir.Enabled = true;
            cmdNovo.Enabled = false;

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

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
