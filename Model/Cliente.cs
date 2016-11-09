using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Clientes")]
    public class Cliente  : Pessoa
    {
        [Key]
        public int IdCliente{ get; set; }
        public virtual CarteiraDeMotorista Carteira { get; set; }
        public int IdCarteiraDeMotorista { get; set; }
        public override string ToString() 
        {
            return String.Format("Cliente id:{0}, Nome:{1}, Rg:{2}", this.IdCliente,this.Nome,this.Rg);
        }
    }
}