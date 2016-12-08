using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class MarcasController 
    {
        private EntidadesContext contexto = new EntidadesContext();

        public IList<Marca> Listar()
        {
            return new MarcaDao(contexto).Listar();
        }

        public Marca BuscaPorId(int id)
        {
            Marca marca  = new MarcaDao(contexto).BuscaPorId(id);
            if (marca == null)
            {
                throw new Exception("Marca não encontrado");
            }
            return marca;
        }

        public bool incluir(Marca marca)
        {
            try
            {
                MarcaDao dao = new MarcaDao(contexto);
                dao.Adicionar(marca);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Marca Alterar(int id, Marca marca)
        {

            try
            {
                MarcaDao dao = new MarcaDao(contexto);
                dao.Alterar(id, marca);
                dao.SaveChanges();
                return marca;
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
                MarcaDao dao = new MarcaDao(contexto);
                Marca marca = dao.BuscaPorId(id);
                if (marca == null)
                {
                    throw new Exception("Marca não encontrada");
                }
                dao.Excluir(marca);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
