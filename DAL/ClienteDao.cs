using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class ClienteDao : IDao<Cliente>
    {
        private EntidadesContext contexto;
        public ClienteDao()
        {
            this.contexto = new EntidadesContext();
        }
        public void Adicionar(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();            
        }
        public void Excluir(Cliente cliente)
        {
            contexto.Clientes.Remove(cliente);
        }
        public IList<Cliente> Listar(){
            return contexto.Clientes.ToList();
        }


    }
}
