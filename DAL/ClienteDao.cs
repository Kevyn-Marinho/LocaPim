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
            try
            {
                contexto.Clientes.Add(cliente);
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
        public void Excluir(Cliente cliente)
        {
            try
            {
                contexto.Clientes.Remove(cliente);
            }
            catch (Exception e)
            {
                throw e;
            } 
        }
        public IList<Cliente> Listar(){
            try
            {
                return contexto.Clientes.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }


    }
}
