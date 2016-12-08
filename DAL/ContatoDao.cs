using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class ContatoDao : IDao<Contato>
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

        public Contato BuscaPorId(int id)
        {
            return contexto.Contatos.FirstOrDefault( c => c.IdContato == id);
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

        public void Editar(int id, Contato contato)
        {
            Contato contatoAntigo = BuscaPorId(id);
            contatoAntigo = contato;
            SaveChanges();
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