using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class LocacoesController
 
    {
        private EntidadesContext contexto = new EntidadesContext();

        public IList<Locacao> Listar()
        {
            return new LocacaoDao(contexto).Listar();
        }

        public Locacao BuscaPorId(int id)
        {
            Locacao locacao= new LocacaoDao(contexto).BuscaPorId(id);
            if (locacao == null)
            {
                throw new Exception("Locacao Não encontrado");
            }
            return locacao;
        }

        public bool incluir(Locacao locacao)
        {
            try
            {
                LocacaoDao dao = new LocacaoDao(contexto);
                dao.Adicionar(locacao);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Locacao Alterar(int id, Locacao locacao)
        {

            try
            {
                LocacaoDao dao= new LocacaoDao(contexto);
                dao.Editar(id, locacao);
                dao.SaveChanges();
                return locacao;
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
                LocacaoDao dao = new LocacaoDao(contexto);
                Locacao locacao= dao.BuscaPorId(id);
                if (locacao == null)
                {
                    throw new Exception("Locacao não encontrado");
                }
                dao.Excluir(locacao);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
