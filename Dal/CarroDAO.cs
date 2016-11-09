using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class CarroDao : IDao<Carro>
    {
        private EntidadesContext contexto;
        public CarroDao(){
            this.contexto = new EntidadesContext();
        }
 
        public void Adicionar(Carro carro) 
        {
            contexto.Carros.Add(carro);
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Carro carro)
        {
            contexto.Carros.Remove(carro);
        }

        public IList<Carro> Listar()
        {
            return contexto.Carros.ToList();
        }
    }
}
