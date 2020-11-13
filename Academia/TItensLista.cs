using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
    class TItensLista
    {
        private int idItem;
        private int idLista;
        private int idExercicio;

        public int IdItem { get => idItem; set => idItem = value; }
        public int IdLista { get => idLista; set => idLista = value; }
        public int IdExercicio { get => idExercicio; set => idExercicio = value; }

        ConexaoDados dados = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into ItensLista (idLista, idExercicio) values (" + IdLista + "," + IdExercicio + ")";
            dados.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update ItensLista SET idLista = '" + IdLista + "',  idExercicio = '" + IdExercicio + "' Where idItem = " + IdItem.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select idLista from ItensLista where idItem = " + IdItem.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            idLista = int.Parse(auxiliar[1]);
            IdExercicio = int.Parse(auxiliar[2]);
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from ItensLista";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosPorID()
        {
            string sql = "";
            sql = "select i.idLista From ItensLista i INNER JOIN Exercicio e " +
                  "ON i.idExercicio = e.idExercicio";
            return dados.Listar(sql);
        }

        public DataSet ListarIdExercicio()
        {
            string sql = "";
            sql = "SELECT e.idExercicio From ItensLista i " +
                  "inner join Exercicio e on i.idExercicio = e.idExercicio WHERE idLista = " + IdLista;
            return dados.Listar(sql);
        }

        public DataSet ListarQuantidadeListaTreino()
        {
            string sql = "";
            sql = "SELECT count(i.idLista) From ItensLista i inner join Exercicio e on i.idExercicio = e.idExercicio inner join ListaTreino l on i.idLista = l.idLista inner join Cliente c on l.idCliente = c.idCliente where i.idLista = " + idLista;
            return dados.Listar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "Delete from ItensLista Where idItem = " + IdItem.ToString();
            dados.Executar(sql);
        }
    }
}
