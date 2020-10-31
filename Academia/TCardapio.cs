using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class TCardapio
    {
        private int idCardapio;
        private int idCliente;
        private int idAlimento;
        private int idProfissional;
        private string dataHora;


        public int IdCardapio { get => idCardapio; set => idCardapio = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdAlimento { get => idAlimento; set => idAlimento = value; }
        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string DataHora { get => dataHora; set => dataHora = value; }
    }
}
