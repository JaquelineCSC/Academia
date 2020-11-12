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
    public partial class FrmLocalizarListaTreino : MetroFramework.Forms.MetroForm
    {
        public FrmLocalizarListaTreino()
        {
            InitializeComponent();
        }

        TListaTreino treino = new TListaTreino();

        private void FrmLocalizarListaTreino_Load(object sender, EventArgs e)
        {
            treino.NomeCliente = "";
            grid1.DataSource = treino.ListarDados().Tables[0];

            grid1.Columns[0].Visible = false;

            grid1.RowHeadersVisible = false;
            grid1.MultiSelect = false;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid1.Rows[0].Selected = true;

            grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid1.AutoResizeRows();
        }
    }
}
