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

        public CargoDao()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adicionar(Cargo cargo)
        {
            contexto.Cargos.Add(cargo);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Cargo cargo)
        {
            contexto.Cargos.Remove(cargo);
        }
        public IList<Cargo> Listar()
        {
            return  contexto.Cargos.ToList();
        }

      }
}
