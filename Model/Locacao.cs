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

        [Required]
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Required]
        public int IdCartaoDeCredito { get; set; }
        public virtual CartaoDeCredito Cartao { get; set; }

        [Required]
        public int IdCarro { get; set; }
        public virtual Carro Carro { get; set; }

        [Required]
        public DateTime DataRetirada { get; set; }

        public DateTime DataDevolucao { get; set; }

        public bool Devolvido { get; set; }


    }
}
