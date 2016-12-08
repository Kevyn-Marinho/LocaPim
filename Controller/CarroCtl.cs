using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class CarroCtl
    {
        private EntidadesContext contexto = new EntidadesContext();


        public IList<Carro> Listar()
        {
            return new CarroDao(contexto).Listar();
        }

        public Carro BuscaPorId(int id)
        {
            if (id == null)
            {
                throw new Exception("Informe o Id");
            }
            Carro carro = new CarroDao(contexto).BuscaPorId(id);

            if (carro == null)
            {
                throw new Exception("Carro Não encontrado");
            }
            return carro;
        }

        public bool Incluir(Carro carro)
        {
            try{
                CarroDao dao = new CarroDao(contexto);
                dao.Adicionar(carro);
                dao.SaveChanges();
                return true;
                //nao funcionando
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Alterar(int id, Carro carro)
        {

            try
            {
                CarroDao dao = new CarroDao(contexto);
                Carro carroAntigo = dao.BuscaPorId(id);
                dao.Alterar(carroAntigo, carro);
                dao.SaveChanges();
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
                CarroDao dao = new CarroDao(contexto);
                Carro carro = dao.BuscaPorId(id);
                if (carro == null)
                {
                    throw new Exception("Usuario não encontrado");
                }
                dao.Excluir(carro);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
