﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Contatos")]
    public class Contato
    {   
        [Key]
        public int IdContato { get; set; }

        [Required]
        public string contato { get; set; }

        public bool Ativo { get; set; }

        [Required]
        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public int IdTipoDeContato { get; set; }
        public virtual TipoDeContato TipoContato { get; set; }
    }
}
