using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Locacoes")]
    public class Locacao
    {
        [Key]
        public int IdLocacao { get; set; }
        public Cliente Cliente { get; set; }
        public int Id { get; set; }

        [Required]
        public CartaoDeCredito Cartao { get; set; }
        public int IdCartaoDeCredito { get; set; }

        [Required]
        public Carro Carro { get; set; }
        public int IdCarro { get; set; }
    
    }
}
