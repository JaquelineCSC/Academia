using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public void IncluirDadosProfissional()
        {
            string sql = "";
            sql += "Insert into Profissional (NomeProfissional, Valor) values ('" + NomeProfissional + "'," + ValorServico.ToString().Replace(",", ".");
            dados.Executar(sql);
        }

        public void AlterarDadosProfissional()
        {
            string sql = "";
            sql += "Update Profissional SET NomeProfissional = '" + NomeProfissional + "',  Valor = " + ValorServico.ToString().Replace(",", ".") + " Where idProfissional = " + IdProfissional.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDadosProfissional()
        {
            string sql = "";
            sql += "Select NomeProfissional from Profissional where idProfissional = " + IdProfissional.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            NomeProfissional = auxiliar[0];
        }

        public DataSet ListarDadosProfissional()
        {
            string sql = "";
            sql = "Select * from Profissional";
            return dados.Listar(sql);
        }

        public void ExcluirDadosProfissional()
        {
            string sql = "Delete from Profissional Where idProfissional = " + IdProfissional.ToString();
            dados.Executar(sql);
        }
    }
}
