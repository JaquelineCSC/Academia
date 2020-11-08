using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
    class TCardapio
    {
        private int idCardapio;
        private int idCliente;
        private int idAlimento;
        private int idProfissional;
        private string dataHora;
        private string aux;

        public int IdCardapio { get => idCardapio; set => idCardapio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdAlimento { get => idAlimento; set => idAlimento = value; }
        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string DataHora { get => dataHora; set => dataHora = value; }
        public string Aux { get => aux; set => aux = value; }

        ConexaoDados dados = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Cardapio (idCliente, idAlimento, idProfissional, DataHora) " +
                "values ('" + IdCliente + "','" + IdAlimento + "','" + idProfissional+ "','" + DataHora + "')";
            dados.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Cardapio SET idCliente = '" + IdCliente + "', idAlimento ='" + IdAlimento + "',  idProfissional = '" + idProfissional + "', DataHora'"+ DataHora + "' Where idCardapio = " + IdCardapio.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select DataHora from Cardapio where idCardapio = " + IdCardapio.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            Aux = IdCliente.ToString();
            Aux = auxiliar[0];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Cardapio";
            return dados.Listar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "Delete from Cardapio Where idCardapio = " + IdAlimento.ToString();
            dados.Executar(sql);
        }
    }
}
