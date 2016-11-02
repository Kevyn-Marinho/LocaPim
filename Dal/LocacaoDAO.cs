using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class LocacaoDao
    {
        private Locacao locacao;

        public LocacaoDao(Locacao locacao)
        {
            this.locacao = locacao;    
        }

        public Boolean RealizaLocacao()
        {
            Conexao conexao = new Conexao();
            SqlConnection conn;
            bool locado = false;

            SqlCommand cmd = new SqlCommand("SP_Funcionarios_ListaCarrega");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 500;

            try
            {
                conn = conexao.AbrirConexao();
                conn.Open();
                cmd.Connection = conn;
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    locado = true;
                }
                conexao.FecharConexao(conn);

                return locado;

            }
            catch (SqlException e)
            {
                throw e;
            }
        }

    }
}
