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
