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
        private string status = "Navegando";
        private void LimpaControle()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            pictureBox1 = null;
        }

        private void HabilitaControle()
        {
            cmdNovo.Enabled = (status == "Navegando");
            cmdLocalizar.Enabled = (status == "Navegando");
            cmdSalvar.Enabled = (status == "Editando" || status == "Inserindo");
            cmdExcluir.Enabled = (status == "Editando");

            if (status == "Inserindo" || status == "Editando")
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Enabled = true;

                    if (ctr is ComboBox)
                        ctr.Enabled = true;

                    if (ctr is DateTimePicker)
                        ctr.Enabled = true;
                }
            }
            else
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Enabled = false;
                    if (ctr is ComboBox)
                        ctr.Enabled = false;
                    if (ctr is DateTimePicker)
                        ctr.Enabled = false;
                }
            }
        }

        private void cmdInserir_Click(object sender, EventArgs e)
        {
            exercicio.NomeExercicio = txtNome.Text;
            exercicio.DescricaoExercicio = txtDescricao.Text;
            exercicio.NivelExercicio = cmbNivel.Text;
            exercicio.RegiaoExercicio = cmbRegiao.Text;


            //if (pictureBox1.Image != null)
            //{
            //exercicio.IncluirDados();
            //MessageBox.Show("Exercicio Adicionado com Sucesso!");
            //}
            //else
            //{
            exercicio.IncluirDadosSemFoto();
            MessageBox.Show("Incluido com Sucesso");
            //}
            LimpaControle();
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            exercicio.NomeExercicio = txtNome.Text;
            exercicio.DescricaoExercicio = txtDescricao.Text;
            exercicio.NivelExercicio = cmbNivel.Text;
            exercicio.RegiaoExercicio = cmbRegiao.Text;

            if (pictureBox1.Image != null)
                exercicio.AlterarDados();
            else
                exercicio.AlterarDadosSemFoto();
            MessageBox.Show("Alterado com Sucesso");
            LimpaControle();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir esse registro?", "Alerta", MessageBoxButtons.YesNo))
            {
                if (status == "Editando")
                {
                    exercicio.ExcluirDados();
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
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
                status = "Inserindo";
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

        private void cmdLocalizar_Click(object sender, EventArgs e)
        {
            cmdSalvar.Enabled = false;
            cmdAlterar.Enabled = true;
            cmdExcluir.Enabled = true;

            FrmLocalizarExercicio F = new FrmLocalizarExercicio();
            F.ShowDialog();

            exercicio.IdExercicio = F.Id;
            exercicio.ConsultarDados();

            txtNome.Text = exercicio.NomeExercicio;
            txtDescricao.Text = exercicio.DescricaoExercicio;
            string nivel = exercicio.NivelExercicio;
            string regiao = exercicio.RegiaoExercicio;

            cmbNivel.Text = nivel;
            cmbRegiao.Text = regiao;

            if (!(exercicio.ImagemExercicio is null))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(exercicio.ImagemExercicio, 0, exercicio.ImagemExercicio.Length);

                pictureBox1.Image = Image.FromStream(ms);
            }
            status = "Editando";
            HabilitaControle();
        }

        private void FrmCadastroExercicio_Load(object sender, EventArgs e)
        {
            HabilitaControle();
        }
    }
}
