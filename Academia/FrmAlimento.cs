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
    public partial class FrmAlimento : MetroFramework.Forms.MetroForm
    {
        public FrmAlimento()
        {
            InitializeComponent();
        }
        TAlimento Alimento = new TAlimento();
        private string status = "Navegando";
        private void FrmAlimento_Load(object sender, EventArgs e)
        {

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            Alimento.NomeAlimento = txtNome.Text;
            Alimento.Calorias = Convert.ToInt32(txtCaloriasx.Text);
            if(status == "Inserindo" )
            {
                Alimento.IncluirDados();
                MessageBox.Show("Alimento Adicionado com Sucesso!");
            }
            if(status == "Editando")
            {
                Alimento.AlterarDados();
            }
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            FrmLocalizarAlimento f = new FrmLocalizarAlimento();
            f.ShowDialog();
            Alimento.IdAlimento = f.Id;
            Alimento.ConsultarDados();
            txtNome.Text = Alimento.NomeAlimento;
            int aux = Alimento.Calorias;
            txtCaloriasx.Text = Convert.ToString(aux);
            status = "Editando";
            HabilitaControle();
        }
        private void HabilitaControle()
        {
            cmdNovo.Enabled = (status == "Navegando");
            cmdPesquisar.Enabled = (status == "Navegando");
            cmdInserir.Enabled = (status == "Editando" || status == "Inserindo");
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
                if(ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }
        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo))
            {
                if (status == "Editando")
                {
                    Alimento.ExcluirDados();
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }
    }
}
