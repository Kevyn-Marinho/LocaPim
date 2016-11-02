using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class CargoDao : IDao
    {

        private Cargo cargo;

        public CargoDao(Cargo cargo)
        {
            this.cargo = cargo;
        }

        public CargoDao() :this(new Cargo()) { }
        public void Adicionar()
        {

            Conexao conexao = new Conexao();
            SqlConnection conn;

            SqlCommand cmd = new SqlCommand("INSERT INTO TBCARGO (CNMNOME,CDSDESCRICAO,NCDIDSETOR,BIDATIVO) " +
                "VALUES(@NOME,@DESCRICAO,@IDSETOR,@ATIVO)");
            
            cmd.Parameters.AddWithValue("@NOME", cargo.Nome);
            cmd.Parameters.AddWithValue("@DESCRICAO", cargo.Descricao);
            cmd.Parameters.AddWithValue("@IDSETOR", cargo.Setor.IdSetor);
            cmd.Parameters.AddWithValue("@ATIVO", cargo.Ativo);
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

            SqlCommand cmd = new SqlCommand("UPDATE TBCARGO SET CNMNOME = @NOME , CDSDESCRICAO= @DESCRICAO, " +
                                            "NCDIDSETOR = @NCDIDSETOR, BIDATIVO = @ATIVO WHERE NCDIDCARGO = @NCDIDCARGO");
            cmd.Parameters.AddWithValue("@NOME", cargo.Nome);
            cmd.Parameters.AddWithValue("@DESCRICAO", cargo.Descricao);
            cmd.Parameters.AddWithValue("@NCDIDSETOR", cargo.Setor.IdSetor);
            cmd.Parameters.AddWithValue("@ATIVO", cargo.Ativo);
            cmd.Parameters.AddWithValue("@NCDIDCARGO", cargo.IdCargo);
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

        public void Excluir(int idCargo)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn;

            SqlCommand cmd = new SqlCommand("DELETE FROM TBCARGO WHERE NCDIDCARGO = @NCDIDCARGO");
            cmd.Parameters.AddWithValue("@NCDIDSETOR", idCargo);
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
        public IList<Cargo> Listar()
        {
            IList<Cargo> cargos = new List<Cargo>();
            SqlDataReader reader;
            StringBuilder str = new StringBuilder();
            str.Append("SELECT "); 
            str.Append("A.NCDIDCARGO,");
            str.Append("A.CNMNOME,");
            str.Append("A.CDSDESCRICAO,");
            str.Append("B.CNMNOME AS SETOR,");
            str.Append("A.BIDATIVO");
            str.Append(" FROM TBCARGO A INNER JOIN TBSETOR B ON B.NCDIDSETOR = A.NCDIDSETOR");

            Conexao conexao = new Conexao();
            SqlConnection conn;

            
            SqlCommand cmd = new SqlCommand(str.ToString());
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
                        Cargo cargo = new Cargo();
                        cargo.IdCargo = int.Parse(reader["NCDIDCARGO"].ToString());
                        cargo.Nome = reader["CNMNOME"].ToString();
                        cargo.Descricao = reader["CDSDESCRICAO"].ToString();
                        cargo.Setor = new Setor();
                        cargo.Setor.Nome = reader["SETOR"].ToString();

                        cargos.Add(cargo);
                    }
                }
                conexao.FecharConexao(conn);

                return cargos;

            }
            catch (SqlException e)
            {
                throw e;
            }

        }


    }
}
