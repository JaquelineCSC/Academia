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
    public partial class FrmLocalizarProfissional : MetroFramework.Forms.MetroForm
    {
        public FrmLocalizarProfissional()
        {
            InitializeComponent();
        }
        TProfissional profissional = new TProfissional();
        public int id;
        private void FrmLocalizarProfissional_Load(object sender, EventArgs e)
        {
            profissional.NomeProfissional = "";
            grid1.DataSource = profissional.ListarDados().Tables[0];
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

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            profissional.NomeProfissional = txtNome.Text;
            grid1.DataSource = profissional.ListarDadosNome().Tables[0];
        }

        private void grid1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(grid1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
