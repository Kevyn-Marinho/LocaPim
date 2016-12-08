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

        public CarroDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
 
        public void Adicionar(Carro carro) 
        {
            try
            {
                contexto.Carros.Add(carro);
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Carro BuscaPorId(int id)
        {
            throw new NotImplementedException();
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

        public void Excluir(Carro carro)
        {
            try
            {
                contexto.Carros.Remove(carro);
                contexto.SaveChanges();
            }catch(Exception e){
                throw e;
            }
        }

        public IList<Carro> Listar()
        {
            try
            {
                return contexto.Carros.ToList();
            }catch(Exception e){
                throw e;
            }
        }

        public void Alterar(Carro carroAntigo, Carro carro)
        {
            
            if(carroAntigo != null)
            {
                carroAntigo = carro;
                contexto.SaveChanges();
            }
        }

    }
}
