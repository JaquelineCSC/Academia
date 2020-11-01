using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class TProfissional
    {
        private int idProfissional;
        private string nomeProfissional;
        private float valorServico;


        public int IdProfissional { get => idProfissional; set => idProfissional = value; }
        public string NomeProfissional { get => nomeProfissional; set => nomeProfissional = value; }
        public float ValorServico { get => valorServico; set => valorServico = value; }

        ConexaoDados dados = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Profissional (NomeProfissional, Valor) values ('" + NomeProfissional + "'," + ValorServico.ToString().Replace(",", ".");
            dados.Executar(sql);
        }
    }
}
