using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class TExercicio
    {
        private int idExercicio;
        private string nomeExercicio;
        private string descricaoExercicio;
        private string nivelExercicio;
        private string regiaoExercicio;
        private byte[] imagemExercicio;


        public int IdExercicio { get => idExercicio; set => idExercicio = value; }
        public string NomeExercicio { get => nomeExercicio; set => nomeExercicio = value; }
        public string DescricaoExercicio { get => descricaoExercicio; set => descricaoExercicio = value; }
        public string NivelExercicio { get => nivelExercicio; set => nivelExercicio = value; }
        public string RegiaoExercicio { get => regiaoExercicio; set => regiaoExercicio = value; }
        public byte[] ImagemExercicio { get => imagemExercicio; set => imagemExercicio = value; }

        ConexaoDados dados = new ConexaoDados();

        public void IncluirDadosExercicio() //Sem incluir foto
        {
            string sql = "";
            sql += "Insert into Exercicio (NomeExercicio, DescricaoExercicio, NivelExercicio, RegiaoExercicio, ImagemExercicio) " +
                "values ('" + NomeExercicio + "','" + DescricaoExercicio + "','" + NivelExercicio + "','" + RegiaoExercicio + ",@BINARIO";
            dados.ExecutarFoto(sql,ImagemExercicio);
        }

        public void AlterarDadosExercicio()
        {
            string sql = "";
            sql += "Update Exercicio SET NomeExercicio = '" + NomeExercicio + "', DescricaoExercicio = '" + DescricaoExercicio + "', NivelExercicio = '" + NivelExercicio + "', RegiaoExercicio = '" + RegiaoExercicio + "', ImagemExercicio = @Binario Where idExercicio = " + IdExercicio.ToString();
            dados.ExecutarFoto(sql,ImagemExercicio);
        }

        //public void ConsultarDadosProfissional()
        //{
        //    string sql = "";
        //    sql += "Select NomeProfissional from Profissional where idProfissional = " + IdProfissional.ToString();
        //    dados.Consultar(sql);
        //    string[] auxiliar = dados.Campos.Split(';');
        //    NomeProfissional = auxiliar[0];
        //}

        //public DataSet ListarDadosProfissional()
        //{
        //    string sql = "";
        //    sql = "Select * from Profissional";
        //    return dados.Listar(sql);
        //}

        //public void ExcluirDadosProfissional()
        //{
        //    string sql = "Delete from Profissional Where idProfissional = " + IdProfissional.ToString();
        //    dados.Executar(sql);
        //}
    }
}
