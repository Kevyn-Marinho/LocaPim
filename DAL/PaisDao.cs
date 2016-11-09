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
        public PaisDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Pais pais)
        {
            contexto.Paises.Add(pais);
            contexto.SaveChanges();
        }
        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public void Excluir(Pais pais)
        {
            contexto.Paises.Add(pais);
            contexto.SaveChanges();
        }
        public IList<Pais> Listar()
        {
            return contexto.Paises.ToList();
        }
        public Pais BuscaPorId(int id)
        {
            return contexto.Paises.FirstOrDefault(u => u.IdPais == id);
        }
        public Pais BuscaPorNome(string nome)
        {
            return contexto.Paises.FirstOrDefault(u=> u.Nome.Equals(nome) );
        }

    }
}
