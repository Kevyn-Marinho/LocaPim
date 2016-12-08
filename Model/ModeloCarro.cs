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

        [Required]
        public int IdMarcaCarro { get; set; }
        public virtual Marca Marcas { get; set; }

        [Required]
        public int IdCategoriaCarro { get; set; }
        public virtual CategoriaCarro Categoria { get; set; }

        }
    }

