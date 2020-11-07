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
        private string status = "Navegando";
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

            if (status == "Inserindo")
            {
                cliente.IncluirDados();
                MessageBox.Show("Cliente Adicionado com Sucesso!");
            }
            if (status == "Editando")
            {
                cliente.AlterarDados();
                MessageBox.Show("Cliente Adicionado com Sucesso!");
            }
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
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
        }

        private void HabilitaControle()
        {
            cmdNovo.Enabled = (status == "Navegando");
            cmdPesquisar.Enabled = (status == "Navegando");
            cmdSalvar.Enabled = (status == "Editando" || status == "Inserindo");
            cmdExcluir.Enabled = (status == "Editando");

            if (status == "Inserindo" || status == "Editando")
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Enabled = true;

                    if (ctr is ComboBox)
                        ctr.Enabled = true;

                    if (ctr is DateTimePicker)
                        ctr.Enabled = true;
                }
            }
            else
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Enabled = false;
                    if (ctr is ComboBox)
                        ctr.Enabled = false;
                    if (ctr is DateTimePicker)
                        ctr.Enabled = false;
                }
            }
        }
        private void LimpaControle()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }


        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            FrmLocalizarCliente f = new FrmLocalizarCliente();
            f.ShowDialog();
            cliente.IdCliente = f.id;
            cliente.ConsultarDados();
            txtNome.Text = cliente.NomeCliente;
            txtRua.Text = cliente.Rua;
            txtBairro.Text = cliente.Bairro;
            txtNumero.Text = cliente.NumCasa;
            metroDateTime1.Text = cliente.DataNascimento;
            txtAvaliacao.Text = cliente.AvaliacaoMedica;
            txtDiaVencimento.Text = cliente.DiaBaseVencimento;
            cmbConhecimento.Text = cliente.NivelConhecimento;
            status = "Editando";
            HabilitaControle();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo))
            {
                if (status == "Editando")
                {
                    cliente.ExcluirDados();
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }
    }
}
