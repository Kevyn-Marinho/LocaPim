using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Dao
{
    public class TipoDeContatoDao
    {
        private EntidadesContext contexto;

        public TipoDeContatoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public void Adicionar(TipoDeContato TipoDeContato)
        {
            try
            {
                contexto.TiposDeContatos.Add(TipoDeContato);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TipoDeContato BuscaPorId(int id)
        {
            return contexto.TiposDeContatos. FirstOrDefault(u => u.IdTipoDeContato == id);
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

        public void Excluir(TipoDeContato TipoDeContato)
        {
            try
            {
                contexto.TiposDeContatos.Remove(TipoDeContato);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<TipoDeContato> Listar()
        {
            try
            {
                return contexto.TiposDeContatos.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(TipoDeContato TipoDeContatoAntigo, TipoDeContato TipoDeContato)
        {

            if (TipoDeContatoAntigo != null)
            {
                TipoDeContatoAntigo = TipoDeContato;
                contexto.SaveChanges();
            }
        }
    }
}
