﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Academia
{
    class TMensalidade
    {
        private int idMensalidade;
        private string dataPagamento;
        private string mesPagamento;
        private int idCliente;
        private float Valor;
        private string nomeCliente;


        public int IdMensalidade { get => idMensalidade; set => idMensalidade = value; }
        public string DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public string MesPagamento { get => mesPagamento; set => mesPagamento = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public float Valor1 { get => Valor; set => Valor = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }

        ConexaoDados dados = new ConexaoDados();

        public void IncluirDados()
        {
            string sql = "";
            sql += "Insert into Mensalidade (DataPagamento, MesPagamento,idCliente, Valor) " + "values ('" + DataPagamento + "','" + MesPagamento + "','" + idCliente + "','"+ Valor1+"')";
            dados.Executar(sql);
        }

        public void AlterarDados()
        {
            string sql = "";
            sql += "Update Mensalidade SET DataPagamento = '" + DataPagamento + "',  MesPagamento = '" + MesPagamento + "' Where idMensalidade = " + IdMensalidade.ToString();
            dados.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = "";
            sql += "Select DataPagamento from Mensalidade where idMensalidade = " + IdMensalidade.ToString();
            dados.Consultar(sql);
            string[] auxiliar = dados.Campos.Split(';');
            DataPagamento = auxiliar[0];
        }

        public DataSet ListarDados()
        {
            string sql = "";
            sql = "Select * from Mensalidade";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosDataPagamento()
        {
            string sql = "";
            sql = "Select c.NomeCliente, m.MesPagamento, m.DataPagamento, m.Valor from Mensalidade m inner join Cliente c on m.idCliente = c.idCliente Where DataPagamento LIKE '" + DataPagamento + "%'";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosMes()
        {
            string sql = "";
            sql = "Select c.NomeCliente, m.MesPagamento, m.DataPagamento, m.Valor from Mensalidade m inner join Cliente c on m.idCliente = c.idCliente Where MesPagamento LIKE '" + MesPagamento + "%'";
            return dados.Listar(sql);
        }

        public DataSet ListarDadosNomeCliente()
        {
            string sql = "";
            sql = "Select c.NomeCliente, m.MesPagamento, m.DataPagamento, m.Valor from Mensalidade m inner join Cliente c on m.idCliente = c.idCliente where c.NomeCliente LIKE '" + NomeCliente + "%'";
            return dados.Listar(sql);
        }

        public void ExcluirDados()
        {
            string sql = "Delete from Mensalidade Where idMensalidade = " + IdMensalidade.ToString();
            dados.Executar(sql);
        }
    }
}
