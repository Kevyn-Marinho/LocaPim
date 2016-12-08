using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;    

namespace Model
{
    [Table("Paises")]
    public class Pais
    {
        [Key]
        public int IdPais { get; set; }

        [Required]
        public String Nome { get; set; }

    }
}
