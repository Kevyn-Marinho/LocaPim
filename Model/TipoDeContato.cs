using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("TiposDeContatos")]
    public class TipoDeContato
    {
        [Key]
        public int IdTipoDeContato { get; set; }
        public string Descricao { get; set; }
    }
}
