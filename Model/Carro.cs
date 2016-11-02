using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Carro
    {
        public int IdCarro { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public ModeloCarro Modelo { get; set; }
        public MarcaCarro Marca { get; set; }
        public bool Locado { get; set; }
        public decimal ValorDiaria { get; set; }
        public int QuantidadeLocacoes { get; set; }

        public Carro()
            : this(new MarcaCarro()) { }

        public Carro(MarcaCarro marca)
            : this(marca, new ModeloCarro()) { }

        public Carro(MarcaCarro marca, ModeloCarro modelo)
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

    }
}
