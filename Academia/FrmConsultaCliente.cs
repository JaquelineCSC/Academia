using MetroFramework.Controls;
using MetroFramework.Interfaces;
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
    public partial class FrmConsultaCliente : MetroFramework.Forms.MetroForm
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        TCliente cliente = new TCliente();
        TExercicio exercicio = new TExercicio();
        TProfissional profissional = new TProfissional();

    }
}
