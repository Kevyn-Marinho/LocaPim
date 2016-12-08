using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Carros")]
    public class Carro
    {
        [Key]
        public int IdCarro { get; set; }

        public string Chassi { get; set; }

        [Required]
        public string Placa { get; set; }

        public DateTime DataFabricacao { get; set; }

        [Required]
        public DateTime DataAquisicao { get; set; }

        public bool Locado { get; set; }

        [Required]
        public decimal ValorDiaria { get; set; }

        public int QuantidadeLocacoes { get; set; }

        [Required]
        public int IdModeloCarro{ get; set; }
        public virtual ModeloCarro ModeloCarro { get; set; }

        [Required]
        public int IdMarcaCarro { get; set; }

       
    }
}
