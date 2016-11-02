using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Dao
{
    public class Conexao
    {
        private String ConnectionString = @"Data Source=BUZZ\SQLEXPRESS;Initial Catalog=DBPIM;Integrated Security=True";

        public SqlConnection AbrirConexao() {

            SqlConnection conn = new SqlConnection(ConnectionString);
            return conn;
        }

        public void FecharConexao(SqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
    
    }


}
