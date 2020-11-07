using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Exercicio (NomeExercicio, DescricaoExercicio, NivelExercicio, RegiaoExercicio, ImagemExercicio) " +
                "values ('" + NomeExercicio + "','" + DescricaoExercicio + "','" + NivelExercicio + "','" + RegiaoExercicio + "', @BINARIO)";
            dados.ExecutarFoto(sql,ImagemExercicio);
        }

        public void IncluirDadosSemFoto()
        {
            string sql = "";
            sql += "Insert into Exercicio (NomeExercicio, DescricaoExercicio, NivelExercicio, RegiaoExercicio) " +
                "values ('" + NomeExercicio + "','" + DescricaoExercicio + "','" + NivelExercicio + "','" + RegiaoExercicio + "')";
            dados.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Exercicio SET NomeExercicio = '" + NomeExercicio + "', DescricaoExercicio = '" + DescricaoExercicio + "', NivelExercicio = '" 
                + NivelExercicio + "', RegiaoExercicio = '" + RegiaoExercicio + "', ImagemExercicio = @Binario Where idExercicio = " + IdExercicio.ToString();
            dados.ExecutarFoto(sql,ImagemExercicio);
        }

        public void AlterarDadosSemFoto()
        {
            string sql = "";
            sql += "Update Exercicio SET NomeExercicio = '" + NomeExercicio + "', DescricaoExercicio = '" + DescricaoExercicio + "', NivelExercicio = '"
                + NivelExercicio + "', RegiaoExercicio = '" + RegiaoExercicio + "' Where idExercicio = " + IdExercicio.ToString();
            dados.Executar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "";
            sql += "Delete from Exercicio where idExercicio = " + IdExercicio.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select * from Exercicio where idExercicio = " + IdExercicio.ToString();

            dados.ConsultarFoto(sql, ref imagemExercicio);

            string[] aux = dados.Campos.Split(';');
            NomeExercicio = aux[1];
            DescricaoExercicio = aux[2];
            NivelExercicio = aux[3];
            RegiaoExercicio = aux[4];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Exercicio";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosNome()
        {
            string sql = "";
            sql = "Select * from Exercicio Where NomeExercicio LIKE '" + NomeExercicio + "%'";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosRegiao()
        {
            string sql = "";
            sql = "Select * from Exercicio Where RegiaoExercicio LIKE '" + RegiaoExercicio + "%'";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosNivel()
        {
            string sql = "";
            sql = "Select * from Exercicio Where NivelExercicio LIKE '" + NivelExercicio + "%'";
            return dados.Listar(sql);
        }
    }
}
