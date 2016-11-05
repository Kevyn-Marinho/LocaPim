using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ModeloCarro
    {
        
        [Key]
        public int IdModeloCarro { get; set; }
        [Required]
        public string Nome { get; set; }
        public Marca Marca { get; set; }
        [Required]
        public int IdMarca { get; set; }        
        public CategoriaCarro Categoria { get; set; }
        [Required]
        public int IdCategoria { get; set; }
    }
}
