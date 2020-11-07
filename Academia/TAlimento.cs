using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
    class TAlimento
    {
        private int idAlimento;
        private string nomeAlimento;
        private int calorias;


        public int IdAlimento { get => idAlimento; set => idAlimento = value; }
        public string NomeAlimento { get => nomeAlimento; set => nomeAlimento = value; }
        public int Calorias { get => calorias; set => calorias = value; }

        ConexaoDados dados = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Alimentos (NomeAlimento, Calorias) " + "values ('" + NomeAlimento + "','" + Calorias + "')";
            dados.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Alimentos SET NomeAlimento = '" + NomeAlimento + "',  Calorias = '" + Calorias + "' Where idAlimento = " + IdAlimento.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select NomeAlimento from Alimentos where idAlimento = " + IdAlimento.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            NomeAlimento = auxiliar[0];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Alimentos";
            return dados.Listar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "Delete from Alimentos Where idAlimento = " + IdAlimento.ToString();
            dados.Executar(sql);
        }
    }
}
