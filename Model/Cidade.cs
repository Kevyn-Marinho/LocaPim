using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key]
        public int IdCidade { get; set; }

        [Required]
        public String NomeCidade { get; set; }

        [Required]
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
