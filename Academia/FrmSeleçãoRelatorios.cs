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
    public partial class FrmSeleçãoRelatorios : MetroFramework.Forms.MetroForm
    {
        public FrmSeleçãoRelatorios()
        {
            InitializeComponent();
        }

        private void FrmSeleçãoRelatorios_Load(object sender, EventArgs e)
        {

        }

        private void cmdSelecionar_Click(object sender, EventArgs e)
        {
            switch (cmbPesquisa.Text)
            {
                case "Relatorio Cliente":
                    FrmRelatorioCliente cliente = new FrmRelatorioCliente();
                    cliente.ShowDialog();
                    break;

                case "Relatorio Profissional":
                    FrmRelatorioProfissional profissional = new FrmRelatorioProfissional();
                    profissional.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
