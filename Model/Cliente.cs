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

        [Required]
        public int IdCarteiraDeMotorista { get; set; }
        public virtual CarteiraDeMotorista CarteiraDeMotorista { get; set; }

    }
}