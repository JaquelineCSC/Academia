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
        TItensLista lista = new TItensLista();
        TCliente cliente = new TCliente();

        string[] itens = new string[20];
        int id;

        public int Id { get => id; set => id = value; }
        public string[] Itens { get => itens; set => itens = value; }

        private void FrmLocalizarListaTreino_Load(object sender, EventArgs e)
        {
            cliente.NomeCliente = "";
            grid1.DataSource = cliente.ListarDadosListaTreino().Tables[0];

            grid1.Columns[0].Visible = false;

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
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo))
            {
                lista.ExcluirDados();
            }

            if (DialogResult.Yes == MessageBox.Show("Deseja Incluir nesse registro?", "Alerta", MessageBoxButtons.YesNo))
            {
                Close();
            }
            Close();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = txtNome.Text;
            grid1.DataSource = cliente.ListarDadosListaTreino().Tables[0];
        }
    }
}
