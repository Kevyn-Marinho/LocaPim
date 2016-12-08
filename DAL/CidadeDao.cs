using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class CidadeDao : IDao<Cidade>
    {
        private EntidadesContext contexto;

        public CidadeDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Cidade cidade)
        {
            try
            {
                contexto.Cidades.Add(cidade);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Cidade BuscaPorId(int id)
        {
            return contexto.Cidades.Find(id);
        }

        public void SaveChanges()
        {
            try
            {
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Cidade cidade)
        {
            try
            {
                contexto.Cidades.Remove(cidade);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Cidade> Listar()
        {
            try
            {
                return contexto.Cidades.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }
                
        public void Editar(int id, Cidade Cidade)
        {
            try
            {
                Cidade cidadeAntiga = BuscaPorId(id);

                if(cidadeAntiga == null)
                {
                    throw new Exception("Não foi possível encontrar a cidade informada");
                }

                cidadeAntiga = Cidade;

                SaveChanges();
            }catch(Exception e)
            {
                throw e;
            }
        }

        public Cidade BuscaPorNome(string nomeCidade)
        {
            return contexto.Cidades.FirstOrDefault(c => c.NomeCidade == nomeCidade);
        }
    }
}

