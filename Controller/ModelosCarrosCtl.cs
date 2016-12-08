using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class ModelosCarrosController
    {
        private EntidadesContext contexto = new EntidadesContext();

        public IList<ModeloCarro> Listar()
        {
            return new ModeloCarroDao(contexto).Listar();
        }

        public ModeloCarro BuscaPorId(int id)
        {
            if (id == null)
            {
                throw new Exception("Informe o Id");
            }

            ModeloCarro modeloCarro = new ModeloCarroDao(contexto).BuscaPorId(id);
            if (modeloCarro == null)
            {
                throw new Exception("Modelo do Carro Não encontrado");
            }
            return modeloCarro;
        }

        public bool incluir(ModeloCarro modeloCarro)
        {
            try
            {
                ModeloCarroDao dao = new ModeloCarroDao(contexto);
                dao.Adicionar(modeloCarro);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public ModeloCarro Alterar(int id, ModeloCarro modeloCarro)
        {

            try
            {
                ModeloCarroDao dao = new ModeloCarroDao(contexto);
                dao.Alterar(id, modeloCarro);
                dao.SaveChanges();
                return modeloCarro;
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
                ModeloCarroDao dao = new ModeloCarroDao(contexto);
                ModeloCarro modeloCarro = dao.BuscaPorId(id);
                if (modeloCarro == null)
                {
                    throw new Exception("Modelo de carro não encontrado");
                }
                dao.Excluir(modeloCarro);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
