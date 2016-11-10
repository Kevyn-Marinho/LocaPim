using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    class CidadeDao : IDao<Cidade>
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
    }
}

