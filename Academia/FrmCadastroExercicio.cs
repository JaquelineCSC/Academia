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
    public partial class FrmCadastroExercicio : MetroFramework.Forms.MetroForm
    {
        public FrmCadastroExercicio()
        {
            InitializeComponent();
        }

        TExercicio exercicio = new TExercicio();

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            exercicio.NomeExercicio = txtNome.Text;
            exercicio.DescricaoExercicio = txtDescricao.Text;
            exercicio.NivelExercicio = cmbNivel.Text;
            exercicio.RegiaoExercicio = cmbRegiao.Text;

            exercicio.IncluirDados();
        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
