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

        public EstadoDao()
        {
            this.contexto = new EntidadesContext();
        }
        public void Adicionar(Estado estado)
        {
            contexto.Estado.Add(estado);
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Estado estado)
        {
            contexto.Estado.Remove(estado);
        }

        public IList<Estado> Listar()
        {
            return contexto.Estado.ToList();
        }
    }
}
