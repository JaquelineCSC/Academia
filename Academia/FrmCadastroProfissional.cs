using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academia
{
    public partial class FrmCadastroProfissional : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroProfissional()
        {
            InitializeComponent();
        }

        TProfissional profissional = new TProfissional();
        private string status = "Navegando";

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            profissional.NomeProfissional = txtNome.Text;
            profissional.ValorServico = float.Parse(txtValor.Text);
            if (status == "Inserindo")
            {
                profissional.IncluirDados();
                MessageBox.Show("Profissional Adicionado com Sucesso!");
            }
            if (status == "Editando")
            {
                profissional.AlterarDados();
            }
        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdNovo_Click(object sender, EventArgs e)
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
            FrmLocalizarProfissional f = new FrmLocalizarProfissional();
            f.ShowDialog();
            profissional.IdProfissional = f.id;
            profissional.ConsultarDados();
            txtNome.Text = profissional.NomeProfissional;
            txtValor.Text = profissional.ValorServico.ToString();
            status = "Editando";
            HabilitaControle();
        }
        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo))
            {
                if (status == "Editando")
                {
                    profissional.ExcluirDados();
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }

        private void FrmCadastroProfissional_Load(object sender, EventArgs e)
        {
            HabilitaControle();
        }
    }
}
