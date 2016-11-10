using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public class EstadoDao : IDao<Estado>
    {
        private EntidadesContext contexto;

        public EstadoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Estado estado)
        {
            try
            {
                contexto.Estado.Add(estado);
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

        public void Excluir(Estado estado)
        {
            try
            {
                contexto.Estado.Remove(estado);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public IList<Estado> Listar()
        {
            try
            {
                return contexto.Estado.Include("Pais").ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
