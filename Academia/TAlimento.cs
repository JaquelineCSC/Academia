using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
