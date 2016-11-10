using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    class CategoriaCarroDao : IDao<CategoriaCarro>
    {
        private EntidadesContext contexto;

        public CategoriaCarroDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(CategoriaCarro categoria)
        {
            try
            {
                contexto.Categorias.Add(categoria);
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

        public void Excluir(CategoriaCarro categoria)
        {
            try
            {
                contexto.Categorias.Remove(categoria);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<CategoriaCarro> Listar()
        {
            try
            {
                return contexto.Categorias.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }    
    }
}

