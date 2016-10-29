using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Collections;
using System.Data.SqlClient;
namespace DAL
{
    public class FuncionarioDAL : IDao
    {
        private Funcionario funcinoario;

        public FuncionarioDAL(Funcionario funcionario)
        {
            this.funcinoario = funcionario;
        }

        public void Incluir()
        {
            throw new NotImplementedException();
        }

        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public Funcionario Buscar()
        {
            throw new NotImplementedException();
        }

        public IList<Funcionario> Listar()
        {
            IList<Funcionario> funcionarios = new List<Funcionario>();
            SqlCommand cmd = new SqlCommand("SP_Funcionarios_ListaCarrega");
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
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Funcionario f = new Funcionario();
                        f.Ativo = Boolean.Parse(reader["BIDATIVO"].ToString());
                        f.IdPessoa = int.Parse(reader["NCDIDPESSOA"].ToString());
                        f.Nome = reader["CNMNOME"].ToString();
                        f.Sobrenome = reader["CNMSOBRENOME"].ToString();
                        f.Rg = reader["CDSRG"].ToString();
                        f.Cpf = reader["CDSCPF"].ToString();
                        f.DataNascimento = DateTime.Parse(reader["DDTNASCIMENTO"].ToString());
                        funcionarios.Add(f);
                    }
                }
                conexao.FecharConexao(conn);
                return funcionarios;

            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
