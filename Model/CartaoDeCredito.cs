using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class CartaoDeCredito
    {
        public int IdCartaoDeCredito { get; set; }
        
        public OperadoraCartao Operadora {get; set;}
        
        public DateTime Validade { get; set; }
        public string NumeroCartao { get; set; }
        public int CodigoSeguranca { get; set; }
        public string NomeCartao { get; set; }
        public Cliente Cliente { get; set; }
        public bool Ativo { get; set; }
    }
}