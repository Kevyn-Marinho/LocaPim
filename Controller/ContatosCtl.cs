using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class ContatosController 
    {
        private EntidadesContext contexto = new EntidadesContext();

        public IList<Contato> Listar()
        {
            return new ContatoDao(contexto).Listar();
        }

        public Contato BuscaPorId(int id)
        {
            Contato contato = new ContatoDao(contexto).BuscaPorId(id);
            if (contato == null)
            {
                throw new Exception("Cargo Não encontrado");
            }
            return contato;
        }

        public bool incluir(Contato contato)
        {
            try
            {
                ContatoDao dao= new ContatoDao(contexto);
                dao.Adicionar(contato);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Contato Alterar(int id, Contato contato)
        {

            try
            {
                ContatoDao dao = new ContatoDao(contexto);
                dao.Editar(id, contato);
                dao.SaveChanges();
                return contato;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        public void Delete(int id)
        {
            try
            {
                ContatoDao dao = new ContatoDao(contexto);
                Contato contato = dao.BuscaPorId(id);
                if ( contato == null)
                {
                    throw new Exception("Usuario não encontrado");
                }
                dao.Excluir(contato);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
