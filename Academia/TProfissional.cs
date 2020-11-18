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

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Profissional (NomeProfissional, ValorServico) " + "values ('" + NomeProfissional + "','" + ValorServico.ToString("0.00").Replace(",",".") + "')";
            dados.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Profissional SET NomeProfissional = '" + NomeProfissional + "',  ValorServico = " + ValorServico.ToString("0.00").Replace(",", ".") + " Where idProfissional = " + IdProfissional.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select NomeProfissional from Profissional where idProfissional = " + IdProfissional.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            NomeProfissional = auxiliar[1];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Profissional";
            return dados.Listar(sql);
        }
        public DataSet ListarDadosNome()
        {
            string sql = "";
            sql = "Select * from Profissional Where NomeProfissional LIKE '" + NomeProfissional + "%'";
            return dados.Listar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "Delete from Profissional Where idProfissional = " + IdProfissional.ToString();
            dados.Executar(sql);
        }
    }
}
