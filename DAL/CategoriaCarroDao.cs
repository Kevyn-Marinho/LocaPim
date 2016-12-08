using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class CategoriaCarroDao : IDao<CategoriaCarro>
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

        public void Alterar(int idCategoriaAntiga, CategoriaCarro cat)
        {

            try
            {
                CategoriaCarro antigo = BuscaPorId(idCategoriaAntiga);
                if (antigo == null)
                {
                    throw new Exception("Não foi possível localizar a marca informada.");
                }

                antigo = cat;
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public CategoriaCarro BuscaPorId(int id)
        {
            return contexto.Categorias.FirstOrDefault(c => c.IdCategoriaCarro == id);
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }    
    }
}

