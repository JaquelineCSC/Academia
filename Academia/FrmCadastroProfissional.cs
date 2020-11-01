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
    public partial class FrmCadastroProfissional : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroProfissional()
        {
            InitializeComponent();
        }

        TProfissional profissional = new TProfissional();

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            profissional.NomeProfissional = txtNome.Text;
            profissional.ValorServico = float.Parse(txtValor.Text);
        }
    }
}
