using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Cliente  : Pessoa
    {
        public int IdCliente{ get; set; }
        public CarteiraDeMotorista Carteira { get; set; }
        
        public override string ToString() 
        {
            return String.Format("Cliente id:{0}, Nome:{1}, Rg:{2}", this.IdCliente,this.Nome,this.Rg);
        }
    }
}