using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class LocacaoDao : IDao<Locacao>
    {
        private EntidadesContext contexto;
        public LocacaoDao()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adicionar(Locacao locacao)
        {
            contexto.Locacoes.Add(locacao);
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Locacao locacao)
        {
            contexto.Locacoes.Remove(locacao);
        }

        public IList<Locacao> Listar()
        {
            return contexto.Locacoes.ToList();
        }
    }
}
