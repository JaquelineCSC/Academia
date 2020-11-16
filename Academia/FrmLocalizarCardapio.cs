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
    public partial class FrmLocalizarCardapio : MetroFramework.Forms.MetroForm
    {
        public FrmLocalizarCardapio()
        {
            InitializeComponent();
        }

        TCardapio cardapio = new TCardapio();


        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            cardapio.Nome = txtNome.Text;
            grid1.DataSource = cardapio.ListarDadosNomeCliente().Tables[0];
        }

        private void FrmLocalizarCardapio_Load(object sender, EventArgs e)
        {
            cardapio.Nome = "";
            grid1.DataSource = cardapio.ListarDados().Tables[0];
            grid1.RowHeadersVisible = false;
            grid1.Rows[0].Selected = true;
            grid1.MultiSelect = false;
            grid1.ReadOnly = true;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid1.AutoResizeRows();
        }
    }
}
