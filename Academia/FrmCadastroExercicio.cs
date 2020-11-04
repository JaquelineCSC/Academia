using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            MessageBox.Show("Incluido com Sucesso");
        }

        private void cmdVoltarMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(nome);

                ConverteFoto();
            }
        }

        private void ConverteFoto()
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] foto_array = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(foto_array, 0, foto_array.Length);
                exercicio.ImagemExercicio = foto_array;
            }
        }
    }
}
