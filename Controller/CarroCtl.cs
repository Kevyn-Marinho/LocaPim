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
     public IList<Carro> Listar(){
         return new CarroDao().Listar();
     }

     public void Adicionar(Carro carro)
     {
         new CarroDao().Adicionar(carro);
     }

    }
}
