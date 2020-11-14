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
    public partial class FrmSeleçãoConsulta : MetroFramework.Forms.MetroForm
    {
        public FrmSeleçãoConsulta()
        {
            InitializeComponent();
        }

        private void cmbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdConsultar.Enabled = true;
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            switch (cmbPesquisa.Text)
            {
                case "Alimento":
                    FrmLocalizarAlimento alimento = new FrmLocalizarAlimento();
                    alimento.ShowDialog();
                    break;

                case "Cliente":
                    FrmLocalizarCliente cliente = new FrmLocalizarCliente();
                    cliente.ShowDialog();
                    break;

                case "Exercicio":
                    FrmLocalizarExercicio exercicio = new FrmLocalizarExercicio();
                    exercicio.ShowDialog();
                    break;

                case "Profissional":
                    FrmLocalizarProfissional profissional = new FrmLocalizarProfissional();
                    profissional.ShowDialog();
                    break;
                case "Mensalidade":
                    FrmLocalizarMensalidade mensalidade = new FrmLocalizarMensalidade();
                    mensalidade.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
