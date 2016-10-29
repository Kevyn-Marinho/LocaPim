using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
namespace Controller
{
    public class ClienteController
    {
        public Boolean CadastraCliente(Cliente cliente)
        {
            ClienteDAL dao = new ClienteDAL();
            return dao.CadastraCliente(cliente);
        }

        public List<Cliente> BuscaCliente(Cliente cliente)
        {
            ClienteDAL dao = new ClienteDAL();
            return dao.BuscaCliente(cliente);
        }

        public Boolean AlteraCliente(Cliente cliente)
        {
            ClienteDAL dao = new ClienteDAL();
            return dao.AlteraCliente(cliente);
        }

        public Boolean InativaCliente(Cliente cliente)
        {
            ClienteDAL dao = new ClienteDAL();
            return dao.ExcluirCliente(cliente);
        }
    }
}
