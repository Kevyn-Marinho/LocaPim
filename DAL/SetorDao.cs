using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;
namespace Dao
{
    public class SetorDao : IDao
    {
        private Setor setor;

        public SetorDao(Setor setor)
        {
            this.setor = setor;
        }
        public SetorDao()
            : this(new Setor())
        {
        }

        public void Adicionar(){
            
            Conexao conexao = new Conexao();
            SqlConnection conn;
            
            SqlCommand cmd = new SqlCommand("INSERT INTO TBSETOR (CNMNOME,CDSDESCRICAO) VALUES(@NOME,@DESCRICAO)");
            cmd.Parameters.AddWithValue("@NOME", setor.Nome);
            cmd.Parameters.AddWithValue("@DESCRICAO", setor.Descricao);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 500;

            try
            {
                conn = conexao.AbrirConexao();
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conexao.FecharConexao(conn);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public void Editar()
        {
            Conexao conexao = new Conexao();
            SqlConnection conn;

            SqlCommand cmd = new SqlCommand("UPDATE TBSETOR SET CNMNOME = @NOME ,CDSDESCRICAO= @DESCRICAO "+
                                            "WHERE NCDIDSETOR = @NCDIDSETOR");
            cmd.Parameters.AddWithValue("@NOME", setor.Nome);
            cmd.Parameters.AddWithValue("@DESCRICAO", setor.Descricao);
            cmd.Parameters.AddWithValue("@NCDIDSETOR", setor.IdSetor);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 500;

            try
            {
                conn = conexao.AbrirConexao();
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conexao.FecharConexao(conn);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public void Excluir(int idSetor)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn;

            SqlCommand cmd = new SqlCommand("DELETE FROM TBSETOR WHERE NCDIDSETOR = @NCDIDSETOR");
            cmd.Parameters.AddWithValue("@NCDIDSETOR", idSetor);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 500;

            try
            {
                conn = conexao.AbrirConexao();
                conn.Open();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conexao.FecharConexao(conn);
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        public IList<Setor> Listar()
        {
            IList<Setor> setores = new List<Setor>();
            SqlDataReader reader;
            
            Conexao conexao = new Conexao();
            SqlConnection conn;

            SqlCommand cmd = new SqlCommand("SELECT	NCDIDSETOR,CNMNOME,CDSDESCRICAO FROM TBSETOR");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandTimeout = 500;
            
            try
            {
                conn = conexao.AbrirConexao();
                conn.Open();
                cmd.Connection = conn;
                
                reader = cmd.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Setor setor = new Setor();
                        setor.IdSetor = int.Parse(reader["NCDIDSETOR"].ToString());
                        setor.Nome = reader["CNMNOME"].ToString();
                        setor.Descricao = reader["CDSDESCRICAO"].ToString();
                        setores.Add(setor);
                    }
                }
                conexao.FecharConexao(conn);
                
                return setores;

            }
            catch (SqlException e)
            {
                throw e;
            }

        }

    }
}
