using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class CarroDAO : IDao
    {
        private Carro carro;

        public CarroDAO()
            : this(new Carro()) { }
        

        public CarroDAO(Carro carro) 
        {
            this.carro = carro;
        }

        public void Incluir() 
        {
            Conexao conexao = new Conexao();
            SqlConnection conn;

            SqlCommand cmd = new SqlCommand("INSERT INTO TBCARRO (CCDCHASSI,CCDPLACA,DDTDATAFABRICACAO,DDTDATAAQUISICAO,"+
                "NNRQTDEDELOCACOES,NCDIDMODELOCARRO,BIDLOCADO,NVLDIARIA)" + 
                "VALUES (@CCDCHASSI,@CCDPLACA,@DDTDATAFABRICACAO, @DDTDATAAQUISICAO,@NNRQTDEDELOCACOES, " +  
                        "@NCDIDMODELOCARRO,@BIDLOCADO,@NVLDIARIA)");

            cmd.Parameters.AddWithValue("@CCDCHASSI", carro.Chassi);
            cmd.Parameters.AddWithValue("@CCDPLACA", carro.Placa);
            cmd.Parameters.AddWithValue("@DDTDATAFABRICACAO", carro.DataFabricacao);
            cmd.Parameters.AddWithValue("@DDTDATAAQUISICAO", carro.DataAquisicao);
            cmd.Parameters.AddWithValue("@NNRQTDEDELOCACOES", carro.QuantidadeLocacoes);
            cmd.Parameters.AddWithValue("@NCDIDMODELOCARRO", carro.Modelo.IdModeloCarro);
            cmd.Parameters.AddWithValue("@BIDLOCADO", carro.Locado);
            cmd.Parameters.AddWithValue("@NVLDIARIA", carro.ValorDiaria);

            try
            {
                conn = conexao.AbrirConexao();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandTimeout = 500;
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();

                conexao.FecharConexao(conn);

            }
            catch (SqlException e)
            {
                throw e;
            }

        }
        
        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }

        public IList<Carro> Listar()
        {
            IList<Carro> frota = new List<Carro>();
            SqlCommand cmd = new SqlCommand("SP_Frota_ListaCarrega");
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
                        Carro carro = new Carro();

                        carro.IdCarro = int.Parse(reader["NCDIDCARRO"].ToString());
                        carro.Chassi = reader["CCDCHASSI"].ToString();
                        carro.DataFabricacao = DateTime.Parse(reader["DDTDATAFABRICACAO"].ToString());
                        carro.DataAquisicao = DateTime.Parse(reader["DDTDATAAQUISICAO"].ToString());
                        carro.QuantidadeLocacoes = int.Parse(reader["NNRQTDEDELOCACOES"].ToString());
                        carro.Locado = bool.Parse(reader["BIDLOCADO"].ToString());
                        carro.ValorDiaria = decimal.Parse(reader["NVLDIARIA"].ToString());
                        carro.Marca = new MarcaCarro();
                        carro.Marca.Nome = reader["CNMMARCACARRO"].ToString();
                        carro.Modelo = new ModeloCarro();
                        carro.Modelo.Nome = reader["CDSMODELOCARRO"].ToString();
                        carro.Modelo.Categoria = new CategoriaCarro();
                        carro.Modelo.Categoria.Nome = reader["CNMCATEGORIACARRO"].ToString();

                        frota.Add(carro);
                    }
                }
                conexao.FecharConexao(conn);

                return frota;

            }
            catch (SqlException e)
            {
                throw e;
            }

        }
    }
}
