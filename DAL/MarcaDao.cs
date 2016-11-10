using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    class MarcaDao : IDao<Marca>
    {
        private EntidadesContext contexto;

        public MarcaDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Marca marca)
        {
            try
            {
                contexto.Marcas.Add(marca);
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

        public void Excluir(Marca marca)
        {
            try
            {
                contexto.Marcas.Remove(marca);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public IList<Marca> Listar()
        {
            try
            {
                return contexto.Marcas.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}

