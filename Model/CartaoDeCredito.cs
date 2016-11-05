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
        public DateTime Validade { get; set; }
        public string NumeroCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public string NomeCartao { get; set; }
        public bool Ativo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int IdCliente { get; set; }
        public virtual OperadoraCartao Operadora { get; set; }
        public int IdOperadora { get; set; }
    }
}