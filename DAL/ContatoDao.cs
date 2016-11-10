using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    class ContatoDao : IDao<Contato>
    {
        private EntidadesContext contexto;

        public ContatoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Contato contato)
        {
            try
            {
                contexto.Contatos.Add(contato);
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

        public void Excluir(Contato contato)
        {
            try
            {
                contexto.Contatos.Remove(contato);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Contato> Listar()
        {
            try
            {
                return contexto.Contatos.ToList();

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