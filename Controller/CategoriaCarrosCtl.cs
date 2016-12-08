using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class CategoriaCarrosController 
    {
        private EntidadesContext contexto = new EntidadesContext();


        public IList<CategoriaCarro> Listar()
        {
            return new CategoriaCarroDao(contexto).Listar();
        }

        public CategoriaCarro BuscaPorId(int id)
        {
            if (id == null)
            {
                throw new Exception("Informe o Id");
            }

            CategoriaCarro categoriacarro = new CategoriaCarroDao(contexto).BuscaPorId(id);
            if (categoriacarro == null)
            {
                throw new Exception("Categoria de Carro não encontrado");
            }
            return categoriacarro;
        }

        public bool incluir(CategoriaCarro categoriacarro)
        {
            try
            {
                CategoriaCarroDao dao = new CategoriaCarroDao(contexto);
                dao.Adicionar(categoriacarro);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public CategoriaCarro Alterar(int idAntiga, CategoriaCarro categoriacarro)
        {

            try
            {
                CategoriaCarroDao dao = new CategoriaCarroDao(contexto);
                dao.Alterar(idAntiga, categoriacarro);
                dao.SaveChanges();
                return categoriacarro;
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
                CategoriaCarroDao dao = new CategoriaCarroDao(contexto);
                CategoriaCarro categoriacarro = dao.BuscaPorId(id);
                if (categoriacarro == null)
                {
                    throw new Exception("Usuario não encontrado");
                }
                dao.Excluir(categoriacarro);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
