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
        private Model.Carro carro;
        public CarroCtl(Model.Carro carro)
        {
            this.carro = carro;

            if (this.carro.Marca == null)
            {
                this.carro.Marca = new MarcaCarro();
            }
            
            if (this.carro.Modelo == null)
            {
                this.carro.Modelo = new ModeloCarro();
            }

        }
        public CarroCtl() :this(new Carro())
        {
        }

        public void Adicionar(Carro carro) 
        {
            if (this.carro.Chassi == null)
                throw new Exception("Número do chassi não informado.");

            if (this.carro.Placa == null)
                throw new Exception("Placa não informada.");
        
            CarroDao dao = new CarroDao(this.carro);

            try
            {
                dao.Adicionar();
            }catch(Exception ex){
                throw new Exception("Ocorreu um erro ao adicionar o carro, tente novamente mais tarde. \n Error Message:"  + ex.Message);
            }
            
        }

        public IList<Carro> ListaFrota()
        {
            IList<Carro> frota;
            try
            {
                frota = new CarroDao().Listar();
                return frota;
                
            }catch(Exception ex)
            {
                throw ex;
            }

        }



    }
}
