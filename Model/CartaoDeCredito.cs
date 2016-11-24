using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("CartoesDeCredito")]
    public class CartaoDeCredito
    {
        [Key]
        public int IdCartaoDeCredito { get; set; }
        [Required]
        public DateTime Validade { get; set; }
        [Required]
        public string NumeroCartao { get; set; }
        [Required]
        public int CodigoSeguranca { get; set; }
        [Required]
        public string NomeCartao { get; set; }

        public bool Ativo { get; set; }

        [Required]
        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }

        [Required]
        public virtual OperadoraCartao Operadora { get; set; }
        public int IdOperadoraCartao { get; set; }
    }
}