using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class TMensalidade
    {
        private int idMensalidade;
        private string dataPagamento;
        private string mesPagamento;
        private int idCliente;


        public int IdMensalidade { get => idMensalidade; set => idMensalidade = value; }
        public string DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public string MesPagamento { get => mesPagamento; set => mesPagamento = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
