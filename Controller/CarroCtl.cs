using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;

namespace Business
{
    public class CarroCtl
    {
        private EntidadesContext contexto;

        public CarroCtl()
        {
            this.contexto = new EntidadesContext();
        }
        public IList<Carro> Listar(){
            try
            {
                return new CarroDao(contexto).Listar();
            }catch(Exception e){
                throw e;
            }
        }
        public void Adicionar(Carro carro)
        {
            try
            {
                new CarroDao(contexto).Adicionar(carro);
            }catch(Exception e){
                throw e;
            }
        }
        public void SalvarAlteracoes()
        {
            try
            {
                new CarroDao(contexto).SaveChanges();
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
                new CarroDao(contexto).Excluir(carro);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
