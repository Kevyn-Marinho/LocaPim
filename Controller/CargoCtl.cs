using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class CargoCtl 
    {
        private EntidadesContext contexto = new EntidadesContext();
                
        public IList<Cargo> Listar()
        {
            return new CargoDao(contexto).Listar();
        }

        public Cargo BuscaPorId(int id)
        {
            if (id == null)
            {
                throw new Exception("Informe o Id");
            }

            Cargo cargo = new CargoDao(contexto).BuscaPorId(id);
            if (cargo == null)
            {
                throw new Exception("Cargo Não encontrado");
            }
            return cargo;
        }

        public bool incluir(Cargo cargo)
        {
            try {
                CargoDao dao = new CargoDao(contexto);
                dao.Adicionar(cargo);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Alterar(int id, Cargo cargo)
        {

            try
            {
                CargoDao dao = new CargoDao(contexto);
                Cargo cargoAntigo = dao.BuscaPorId(id);
                dao.Editar(cargoAntigo, cargo);
                dao.SaveChanges();
            }catch(Exception E)
            {
                throw E;
            }
        }

        public void Delete(int id)
        {
            try
            {
                CargoDao dao = new CargoDao(contexto);
                Cargo cargo = dao.BuscaPorId(id);
                if (cargo == null)
                {
                    throw new Exception("Usuario não encontrado");
                }
                dao.Excluir(cargo);
            }
            catch (Exception e) {
                throw e;
            }

        }

    }
}
