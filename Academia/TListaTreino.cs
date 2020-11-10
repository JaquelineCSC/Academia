using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
    public class TListaTreino
    {
        private int idLista;
        private int idCliente;
        private int idProfissional;
        private string dataTreino;
        //teste
        private string nomeCliente;
        private string nomeProfissional;

        public int IdLista { get => idLista; set => idLista = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string DataTreino { get => dataTreino; set => dataTreino = value; }
        //teste
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string NomeProfissional { get => nomeProfissional; set => nomeProfissional = value; }

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
            //sql += "Select * from ListaTreino where idLista = " + IdLista.ToString();

            sql = "select l.*, c.NomeCliente, p.NomeProfissional from Cliente c INNER JOIN ListaTreino l ON c.idCliente = l.idCliente " +
                  "inner join Profissional p ON l.idProfissional = p.idProfissional where idLista = " + idLista.ToString();

            dados.Consultar(sql);

            string[] auxiliar = dados.Campos.Split(';');
            idLista = int.Parse(auxiliar[0]);
            idCliente = int.Parse(auxiliar[1]);
            idProfissional = int.Parse(auxiliar[2]);
            DataTreino = auxiliar[3];

            nomeCliente = auxiliar[4];
            nomeProfissional = auxiliar[5];
        }

        public void ConsultarDadosSimples()
        {
            string sql = "";
            
            sql += "Select * from ListaTreino where idLista = " + IdLista.ToString();

            dados.Consultar(sql);

            string[] auxiliar = dados.Campos.Split(';');
            idLista = int.Parse(auxiliar[0]);
            idCliente = int.Parse(auxiliar[1]);
            idProfissional = int.Parse(auxiliar[2]);
            DataTreino = auxiliar[3];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from ListaTreino";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosCompleto()
        {
            string sql = "";
            sql = "select l.*, c.NomeCliente, p.NomeProfissional from Cliente c INNER JOIN ListaTreino l ON c.idCliente = l.idCliente " +
                  "inner join Profissional p ON l.idProfissional = p.idProfissional";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosNomeCliente()
        {
            string sql = "";
            sql = "Select c.NomeCliente from Cliente c INNER JOIN ListaTreino l ON c.idCliente = l.idCliente";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosNomeProfissional()
        {
            string sql = "";
            sql = "Select p.NomeProfissional from Profissional p INNER JOIN ListaTreino l ON p.idProfissional = l.idProfissional";
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
