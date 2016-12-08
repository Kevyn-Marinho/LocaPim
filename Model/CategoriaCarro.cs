using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Categoria")]
    public class CategoriaCarro
    {
        [Key]
        public int IdCategoriaCarro { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

    }
}
