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
        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from ItensLista";
            return dados.Listar(sql);
        }
    }
}
