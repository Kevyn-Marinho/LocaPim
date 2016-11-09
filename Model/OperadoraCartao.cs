using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class OperadoraCartao
    {
        [Key]
        public int IdOperadoraCarta { get; set; }
        [Required]
        public string Bandeira { get; set; }
        public bool Ativo { get; set; } 

    }
}
