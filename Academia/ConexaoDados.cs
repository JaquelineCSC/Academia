using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Academia
{
    class ConexaoDados
    {
        private string campos;
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cd = new SqlCommand();

        public string Campos { get => campos; set => campos = value; }

        private void Conectar()
        {
            string s = "";
            s = @"Server=.\SQLEXPRESS;Database=Academia;UID=sa;PWD=123;";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void Executar(string sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

        //public void ExecutarFoto(string sql, byte[] ParametroFoto)
        //{
        //    Conectar();
        //    cd.Connection = cn;
        //    cd.CommandText = sql;

        //    //A commandText faz a conversao para o tipo SqlDbType - Assim se passa como parametro
        //    //parametro do tipo SQL @BINARIO
        //    //e tambem é o ParametroFoto
        //    cd.Parameters.Add("@BINARIO", SqlDbType.Image);
        //    cd.Parameters["@BINARIO"].Value = ParametroFoto;

        //    cd.ExecuteNonQuery();
        //    cn.Close();
        //}

        public void Consultar(string sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;

            SqlDataReader dr = cd.ExecuteReader();
            Campos = "";

            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Campos += dr[i].ToString() + ";";
                }
            }

            cn.Close();
        }

        public void FecharConexao()
        {
            cn.Close();
        }

        public DataSet Listar(string sql)
        {
            Conectar();

            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cn.Close();
            return ds;
        }
    }
}
