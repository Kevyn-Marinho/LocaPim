using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class MarcaDao : IDao<Marca>
    {
        private EntidadesContext contexto;

        public MarcaDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public Marca BuscaPorId(int id)
        {
            return contexto.Marcas.First(u => u.IdMarcaCarro == id);
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

        public void Alterar(int idMarcaAntiga, Marca marca)
        {

            try
            {
                Marca antiga = this.BuscaPorId(idMarcaAntiga);
                if (antiga == null)
                {
                    throw new Exception("Não foi possível localizar a marca informada.");
                }

                antiga = marca;
                contexto.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }

        }

    }
}

