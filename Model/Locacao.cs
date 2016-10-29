using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Model
{
    public class Locacao
    {
        private Cliente cliente;
        private CartaoDeCredito cartao;
        private Carro carro;

        public Carro Carro { get{ return this.Carro; } }
        public CartaoDeCredito Cartao { get { return this.Cartao; } }
        public Cliente Cliente { get { return this.cliente; } }
        
        public Locacao(Carro carro, Cliente cliente, CartaoDeCredito cartao)
        {
            this.carro  = carro;
            this.cartao =  cartao;
            this.cliente = cliente;
        }
    
    }
}
