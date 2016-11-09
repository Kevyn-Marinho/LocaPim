using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Cnhs")]
    public class CarteiraDeMotorista
    {
        [Key]
        public String Cnh { get; set; }
        [Required]
        public DateTime DataEmissao { get; set; }
        [Required]
        public DateTime Vencimento { get; set; }
        [Required]
        public String Tipo { get; set; }
    }
}