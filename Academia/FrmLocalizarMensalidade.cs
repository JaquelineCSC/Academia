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
    public partial class FrmLocalizarMensalidade : MetroFramework.Forms.MetroForm
    {
        public FrmLocalizarMensalidade()
        {
            InitializeComponent();
        }

        TMensalidade mensalidade = new TMensalidade();
        TCliente cliente = new TCliente();

        private void FrmLocalizarMensalidade_Load(object sender, EventArgs e)
        {
           
            grid1.DataSource = mensalidade.ListarDados().Tables[0];

            grid1.Columns[0].Visible = false;
            grid1.Columns[3].Visible = false;

            grid1.RowHeadersVisible = false;
            grid1.MultiSelect = false;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid1.Rows[0].Selected = true;

            grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid1.AutoResizeRows();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            if (rbDataPagamento.Checked == true)
            {
                mensalidade.DataPagamento = txtNome.Text;
                grid1.DataSource = mensalidade.ListarDadosDataPagamento().Tables[0];
            }
            else if (rbMes.Checked == true)
            {
                mensalidade.MesPagamento = txtNome.Text;
                grid1.DataSource = mensalidade.ListarDadosMes().Tables[0];
            }
        }
    }
}
