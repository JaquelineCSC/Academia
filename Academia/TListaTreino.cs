using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
    class TListaTreino
    {
        private int idLista;
        private int idCliente;
        private int idProfissional;
        private string dataTreino;


        public int IdLista { get => idLista; set => idLista = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string DataTreino { get => dataTreino; set => dataTreino = value; }

        ConexaoDados dados = new ConexaoDados();
        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into ListaTreino (idCliente, idProfissional, DataTreino) values ('" + IdCliente + "','" + IdProfissional + "','" + DataTreino + "')";
            dados.Executar(sql);
        }
        public void AlterarDados()
        {
            string sql = "";
            sql += "Update ListaTreino SET idLista = '" + IdLista + "', idCliente = '" + IdCliente + "', idProfissional = '"
                + IdProfissional + "', DataTreino = '" + DataTreino + "' Where idLista = " + IdLista.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select DataTreino from ListaTreino where idLista = " + IdLista.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            DataTreino = auxiliar[0];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from ListaTreino";
            return dados.Listar(sql);
        }
        public void ExcluirDados()
        {
            string sql = "";
            sql += "Delete from ListaTreino where idLista = " + IdLista.ToString();
            dados.Executar(sql);
        }
    }
}
