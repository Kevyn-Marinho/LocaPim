using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model;

namespace Dao
{
    public class PaisDao : IDao<Pais>
    {
        private EntidadesContext contexto;
        public PaisDao()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adicionar(Pais pais)
        {
            contexto.Paises.Add(pais);
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Pais pais)
        {
            contexto.Paises.Add(pais);
        }
        public IList<Pais> Listar()
        {
            return contexto.Paises.ToList();
        }
    }
}
