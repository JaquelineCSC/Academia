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
            cmdEntrar.Enabled = true;
        }

        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            switch (cmbPesquisa.Text)
            {
                case "Cliente":
                    FrmLocalizarCliente FC = new FrmLocalizarCliente();
                    FC.ShowDialog();
                    break;

                case "Exercicio":
                    FrmLocalizarExercicio FE = new FrmLocalizarExercicio();
                    FE.ShowDialog();
                    break;

                case "Profissional":
                    FrmCadastroProfissional FP = new FrmCadastroProfissional();
                    FP.ShowDialog();
                    break;

                default:
                    break;
            }
        }
    }
}
