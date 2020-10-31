using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class TExercicio
    {
        private int idExercicio;
        private string nomeExercicio;
        private string descricaoExercicio;
        private string nivelExercicio;
        private string regiaoExercicio;
        private byte[] imagemExercicio;


        public int IdExercicio { get => idExercicio; set => idExercicio = value; }
        public string NomeExercicio { get => nomeExercicio; set => nomeExercicio = value; }
        public string DescricaoExercicio { get => descricaoExercicio; set => descricaoExercicio = value; }
        public string NivelExercicio { get => nivelExercicio; set => nivelExercicio = value; }
        public string RegiaoExercicio { get => regiaoExercicio; set => regiaoExercicio = value; }
        public byte[] ImagemExercicio { get => imagemExercicio; set => imagemExercicio = value; }
    }
}
