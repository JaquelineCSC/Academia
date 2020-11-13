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
    public partial class FrmLocalizarAlimento : MetroFramework.Forms.MetroForm
    {
        public FrmLocalizarAlimento()
        {
            InitializeComponent();
        }
        public int Id;
        TAlimento Alimento = new TAlimento();

        //public int Id { get => id; set => id = value; }

        private void FrmLocalizarAlimento_Load(object sender, EventArgs e)
        {
            Alimento.NomeAlimento = "";
            grid1.DataSource = Alimento.ListarDados().Tables[0];
            grid1.Columns[0].Visible = false;
            grid1.Columns[0].Visible = false;
            grid1.RowHeadersVisible = false;
            grid1.Rows[0].Selected = true;
            grid1.MultiSelect = true;
            grid1.ReadOnly = true;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid1.AutoResizeRows();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(grid1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void grid1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            Alimento.NomeAlimento = txtNome.Text;
            grid1.DataSource = Alimento.ListarDados().Tables[0];
        }
    }
}
