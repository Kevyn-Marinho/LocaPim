using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Funcionarios")]
    public class Funcionario : Pessoa
    {
        [Key]
        public bool Usuario { get; set; }
        public Cargo Cargo { get; set; }
        public int IdCargo { get; set; }
     
    }
}