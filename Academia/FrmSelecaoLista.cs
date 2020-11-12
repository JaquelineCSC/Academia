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
    public partial class FrmSelecaoLista : MetroFramework.Forms.MetroForm
    {
        public FrmSelecaoLista()
        {
            InitializeComponent();
        }

        TListaTreino listaTreino = new TListaTreino();
        private int id;

        public int Id { get => id; set => id = value; }

        private void FrmSelecaoLista_Load(object sender, EventArgs e)
        {
            grid1.DataSource = listaTreino.ListarDadosCompleto().Tables[0];

            grid1.Columns[0].Visible = false;
            grid1.Columns[1].Visible = false;
            grid1.Columns[2].Visible = false;
            grid1.Columns[3].Visible = false;

            grid1.RowHeadersVisible = false;
            grid1.MultiSelect = false;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid1.Rows[0].Selected = true;

            grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid1.AutoResizeRows();
        }

        private void grid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (grid1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                Id = int.Parse(grid1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void grid1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
            FrmCadastroItensLista itensLista = new FrmCadastroItensLista(Id);
            itensLista.ShowDialog();
        }
    }
}
