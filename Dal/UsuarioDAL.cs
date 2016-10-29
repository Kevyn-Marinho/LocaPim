using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class UsuarioDAL 
    {
        public List<Usuario> Busca(Usuario usuario)
        {
            int acao = 3;
            SqlCommand cmd = new SqlCommand("SP_CONTAINER_USUARIO");
            cmd.Parameters.AddWithValue("@ACAO", acao);
            cmd.Parameters.AddWithValue("@CNMUSUARIO", usuario.Login);
            cmd.Parameters.AddWithValue("@CDSSENHA", usuario.Senha);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 500;

            Conexao conexao = new Conexao();
            SqlConnection conn;
            SqlDataReader dr;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conn = conexao.AbrirConexao();
                dr = cmd.ExecuteReader();
                conexao.FecharConexao(conn);

                if (dr.Read())
                {
                    while (dr.HasRows)
                    {
                        Usuario u = new Usuario();

                        usuarios.Add(u);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return usuarios;
        }

        public Usuario login(Usuario usuario)
        {
            int acao = 4;
            SqlCommand cmd = new SqlCommand("SP_CONTAINER_USUARIO");
            cmd.Parameters.AddWithValue("@NCDIDFUNCIONARIO", usuario.Funcionario.idFuncionario);
            cmd.Parameters.AddWithValue("@CNMLOGIN", usuario.Login);
            cmd.Parameters.AddWithValue("@CDSSENHA", usuario.Senha);
            cmd.Parameters.AddWithValue("@ACAO", acao);
            cmd.Parameters.AddWithValue("@NNRNIVELACESSO", usuario.NivelDeAcesso);
             
            SqlDataReader reader;
            Conexao conexao = new Conexao();
            SqlConnection conn;

            try
            {
                conn = conexao.AbrirConexao();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandTimeout = 500;
                cmd.Connection = conn;

                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows) { 
                    if (reader.Read())
                    {
                        usuario.IdUsuario =(int)reader["NCDIDUSUARIO"];
                        usuario.Login = (string)reader["CNMLOGIN"];
                        usuario.NivelDeAcesso = (int)reader["NNRNIVELACESSO"];
                    
    

                        Funcionario func = new Funcionario();
                        func.Nome = (string)reader["NOME"];
                        func.Sobrenome = (string)reader["SOBRENOME"];

                        usuario.Funcionario = func;
                    }
                }
                conexao.FecharConexao(conn);
                return usuario;

            }
            catch (SqlException e)
            {
                throw e;
            }

        }

    }
}
