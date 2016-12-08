using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class ModeloCarroDao : IDao<ModeloCarro>
    {
        private EntidadesContext contexto;

        public ModeloCarroDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(ModeloCarro modelo)
        {
            try
            {
                contexto.Modelo.Add(modelo);
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

        public void Excluir(ModeloCarro modelo)
        {
            try
            {
                contexto.Modelo.Remove(modelo);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public IList<ModeloCarro> Listar()
        {
            try
            {
                return contexto.Modelo.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Alterar(int idModeloAntigo, ModeloCarro modelo)
        {
            try
            {
                ModeloCarro antigo = this.BuscaPorId(idModeloAntigo);
                if (antigo == null)
                {
                    throw new Exception("Não foi possível localizar a marca informada.");
                }

                antigo = modelo;
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public ModeloCarro BuscaPorId(int idModeloAntigo)
        {
            return contexto.Modelo.First(m => m.IdModeloCarro == idModeloAntigo);
        }
    }
}
