using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Marcas")]
    public class Marca
    {
        [Key]
        public int IdMarcaCarro { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

    }
}
