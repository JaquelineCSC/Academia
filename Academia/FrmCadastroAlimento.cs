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
    public partial class FrmCadastroAlimento : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroAlimento()
        {
            InitializeComponent();
        }
        TAlimento Alimento = new TAlimento();
        private string status = "Navegando";

        private void LimpaControle()
        {
            txtNome.Text = "";
            txtCaloriasx.Text = "";
        }

        private void HabilitaControle()
        {
            if (status == "Inserindo")
            {
                cmdInserir.Enabled = true;
            }
            else if (status == "Editando")
            {
                cmdInserir.Enabled = true;
                cmdExcluir.Enabled = true;              
            }
            else if (status == "Navegando")
            {
                cmdNovo.Enabled = true;
                cmdPesquisar.Enabled = true;
                cmdInserir.Enabled = false;
                cmdExcluir.Enabled = false;
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            cmdPesquisar.Enabled = false;
            LimpaControle();
            status = "Inserindo";
            cmdPesquisar.Enabled = false;
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
                MessageBox.Show("Alimento Alterado com Sucesso!");
            }
            status = "Navegando";
            HabilitaControle();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            cmdNovo.Enabled = false;
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

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
