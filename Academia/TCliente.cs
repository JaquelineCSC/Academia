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

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select * from Cliente where idCliente = " + IdCliente.ToString();

            dados.Consultar(sql);

            string[] aux = dados.Campos.Split(';');
            NomeCliente = aux[1];
            Rua = aux[2];
            Bairro = aux[3];
            NumCasa = aux[4];
            DataNascimento = aux[5];
            AvaliacaoMedica = aux[6];
            NivelConhecimento = aux[7];
            DiaBaseVencimento = aux[8];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Cliente";
            return dados.Listar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Cliente SET NomeCliente = '" + NomeCliente + "', Rua = '" + Rua + "', Bairro = '"
                + Bairro + "', NumCasa = '" + NumCasa + "', DataNascimento = '" + DataNascimento + "', AvaliacaoMedica'" + AvaliacaoMedica +
                "', NivelConhecimento'" + NivelConhecimento + "', DiaBaseVencimento'" + DiaBaseVencimento + "' Where idCliente = " + IdCliente.ToString();
            dados.Executar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "";
            sql += "Delete from Cliente where idCliente = " + IdCliente.ToString();
            dados.Executar(sql);
        }
    }
}
