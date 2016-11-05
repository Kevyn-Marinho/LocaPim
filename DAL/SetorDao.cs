using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;
namespace Dao
{
    public class SetorDao : IDao<Setor>
    {
        private EntidadesContext contexto; 

        public SetorDao()
        {
            this.contexto = new EntidadesContext();
        }
        public void Adicionar(Setor setor)
        {

            contexto.Setores.Add(setor);
        }
        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public void Excluir(Setor setor)
        {
            contexto.Setores.Remove(setor);
        }
        public IList<Setor> Listar()
        {
            return contexto.Setores.ToList();
        }

    }
}
