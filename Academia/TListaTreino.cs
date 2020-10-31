using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
