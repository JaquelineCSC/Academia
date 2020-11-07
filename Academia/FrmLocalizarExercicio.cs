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
    public partial class FrmLocalizarExercicio : MetroFramework.Forms.MetroForm
    { 
        public FrmLocalizarExercicio()
        {
            InitializeComponent();
        }

        private int id;
        public int Id { get => id; set => id = value; }

        TExercicio exercicio = new TExercicio();

        private void FrmLocalizar_Load(object sender, EventArgs e)
        {
            exercicio.NomeExercicio = "";
            grid1.DataSource = exercicio.ListarDados().Tables[0];

            grid1.Columns[0].Visible = false;
            grid1.Columns[5].Visible = false;

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
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            if (rbNomeExercicio.Checked == true)
            {
                exercicio.NomeExercicio = txtNome.Text;
                grid1.DataSource = exercicio.ListarDadosNome().Tables[0];
            }
            else if (rbRegiao.Checked == true)
            {
                exercicio.RegiaoExercicio = txtNome.Text;
                grid1.DataSource = exercicio.ListarDadosRegiao().Tables[0];
            }

        }

        private void rbRegiao_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
        }

        private void rbNomeExercicio_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
        }
    }
}
