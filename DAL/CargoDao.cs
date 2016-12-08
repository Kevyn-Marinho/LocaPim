using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class CargoDao : IDao<Cargo>
    {
        private EntidadesContext contexto;

        public CargoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public void Adicionar(Cargo cargo)
        {
            try
            {
                contexto.Cargos.Add(cargo);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Cargo BuscaPorId(int id)
        {
            throw new NotImplementedException();
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

        public void Editar(Cargo cargoAntigo, Cargo cargo)
        {
            try
            {
                if (cargoAntigo != null)
                {
                    cargoAntigo = cargo;
                    contexto.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(Cargo cargo)
        {
            try
            {
                contexto.Cargos.Remove(cargo);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Cargo> Listar()
        {
            try
            {
                return contexto.Cargos.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

      }
}
