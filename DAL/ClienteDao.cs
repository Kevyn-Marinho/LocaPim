using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class ClienteDao
    {
        public Boolean CadastraCliente(Cliente cliente)
        {
            Conexao conexao = new Conexao();
            SqlConnection conn;
            bool sucesso = false;
            int acao = 1;
            SqlCommand cmd = new SqlCommand("SP_CONTAINER_CLIENTE");
            cmd.Parameters.AddWithValue("@ACAO", acao);
            cmd.Parameters.AddWithValue("@IDPESSOA", cliente.Id);
            cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
            cmd.Parameters.AddWithValue("@RG", cliente.Rg);
            cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
            cmd.Parameters.AddWithValue("@DTNASCIMENTO", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@ATIVO", cliente.Ativo);
            cmd.Parameters.AddWithValue("@FUNCIONARIO", cliente.Funcionario);
            cmd.Parameters.AddWithValue("@CLIENTE", cliente.Cliente);
            cmd.Parameters.AddWithValue("@CCDCNH", cliente.Carteira.Cnh);
            cmd.Parameters.AddWithValue("@DTEMISSAO", cliente.Carteira.DataEmissao);
            cmd.Parameters.AddWithValue("@DTVENCIMENTO", cliente.Carteira.Vencimento);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 500;

            try
            {
                conn = conexao.AbrirConexao();
                conn.Open();
                cmd.Connection = conn;
                if (cmd.ExecuteNonQuery() > 0) {
                    sucesso = true;
                }
                conexao.FecharConexao(conn);
            }
            catch (SqlException e)
            {
                throw e;
            }
                    
            return sucesso;
        }

        public List<Cliente> BuscaCliente(Cliente cliente)
        {
            int acao = 3;
            SqlCommand cmd = new SqlCommand("SP_CONTAINER_CLIENTE");
            cmd.Parameters.AddWithValue("@ACAO", acao);
            cmd.Parameters.AddWithValue("@IDPESSOA", cliente.Id);
            cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
            cmd.Parameters.AddWithValue("@RG", cliente.Rg);
            cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
            cmd.Parameters.AddWithValue("@DTNASCIMENTO", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@ATIVO", cliente.Ativo);
            cmd.Parameters.AddWithValue("@FUNCIONARIO", cliente.Funcionario);
            cmd.Parameters.AddWithValue("@CLIENTE", cliente.Cliente);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 500;

            Conexao conexao = new Conexao();
            SqlConnection conn;
            SqlDataReader dr;
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                conn = conexao.AbrirConexao();
                 dr = cmd.ExecuteReader();
                conexao.FecharConexao(conn);

                if (dr.Read()) {
                    while (dr.HasRows)
                    {
                        Cliente c = new Cliente();
                        c.IdCliente = Int32.Parse(dr["IDCLIENTE"].ToString());
                        c.Id = Int32.Parse(dr["IDPESSOA"].ToString());
                        c.Nome = dr["NOME"].ToString();	
                        c.Sobrenome = dr["SOBRENOME"].ToString();		
                        c.Rg = dr["RG"].ToString();		
                        c.Cpf= dr["CPF"].ToString();			
                        c.DataNascimento = DateTime.Parse(dr["DTNASCIMENTO"].ToString());	
                        c.Ativo = Boolean.Parse(dr["ATIVO"].ToString());
                        c.Funcionario = Boolean.Parse(dr["FUNCIONARIO"].ToString());	
                        c.Carteira.Cnh = dr["CCDCNH"].ToString();			
                        c.Carteira.DataEmissao= DateTime.Parse(dr["DTEMISSAO"].ToString());		
                        c.Carteira.Vencimento = DateTime.Parse(dr["DTVENCIMENTO"].ToString());

                        clientes.Add(c);
                    }
                }
            }
            catch (SqlException e)
            {
                throw e;
            }

            return clientes;
        }

        public Boolean AlteraCliente(Cliente cliente)
        {
            int acao = 2;
            SqlCommand cmd = new SqlCommand("SP_CONTAINER_CLIENTE");
            cmd.Parameters.AddWithValue("@ACAO", acao);
            cmd.Parameters.AddWithValue("@IDPESSOA", cliente.Id);
            cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
            cmd.Parameters.AddWithValue("@RG", cliente.Rg);
            cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
            cmd.Parameters.AddWithValue("@DTNASCIMENTO", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@ATIVO", cliente.Ativo);
            cmd.Parameters.AddWithValue("@FUNCIONARIO", cliente.Funcionario);
            cmd.Parameters.AddWithValue("@CLIENTE", cliente.Cliente);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 500;

            Conexao conexao = new Conexao();
            SqlConnection conn;

            try
            {
                conn = conexao.AbrirConexao();
                cmd.ExecuteScalar().ToString();
                conexao.FecharConexao(conn);
            }
            catch (SqlException e)
            {
                throw e;
            }

            return true;
        }
        public Boolean ExcluirCliente(Cliente cliente)
        {
            int acao = 4;
            SqlCommand cmd = new SqlCommand("SP_CONTAINER_CLIENTE");
            cmd.Parameters.AddWithValue("@ACAO", acao);
            cmd.Parameters.AddWithValue("@IDPESSOA", cliente.Id);
            cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
            cmd.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
            cmd.Parameters.AddWithValue("@RG", cliente.Rg);
            cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
            cmd.Parameters.AddWithValue("@DTNASCIMENTO", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@ATIVO", cliente.Ativo);
            cmd.Parameters.AddWithValue("@FUNCIONARIO", cliente.Funcionario);
            cmd.Parameters.AddWithValue("@CLIENTE", cliente.Cliente);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 500;

            Conexao conexao = new Conexao();
            SqlConnection conn;

            try
            {
                conn = conexao.AbrirConexao();
                cmd.ExecuteScalar().ToString();
                conexao.FecharConexao(conn);
            }
            catch (SqlException e)
            {
                throw e;
            }

            return true;
        }
    }
}
