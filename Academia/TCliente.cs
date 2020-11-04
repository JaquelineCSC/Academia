using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class TCliente
    {
        private int idCliente;
        private string nomeCliente;
        private string rua;
        private string bairro;
        private string numCasa;
        private string dataNascimento;
        private string avaliacaoMedica;
        private string nivelConhecimento;
        private string diaBaseVencimento;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string NumCasa { get => numCasa; set => numCasa = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string AvaliacaoMedica { get => avaliacaoMedica; set => avaliacaoMedica = value; }
        public string NivelConhecimento { get => nivelConhecimento; set => nivelConhecimento = value; }
        public string DiaBaseVencimento { get => diaBaseVencimento; set => diaBaseVencimento = value; }


        ConexaoDados dados = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Cliente (NomeCliente, Rua, Bairro, NumCasa, DataNascimento, AvaliacaoMedica, NivelConhecimento, DiaBaseVencimento) " +
                                "values ('" + NomeCliente + "','" + Rua + "','" + Bairro + "','" + NumCasa + "','" + DataNascimento + "','" + 
                                        AvaliacaoMedica + "','" + NivelConhecimento + "','" + DiaBaseVencimento + "')";
            dados.Executar(sql);
        }
    }
}
