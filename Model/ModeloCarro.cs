using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ModeloCarro
    {
        public ModeloCarro() :this(new MarcaCarro()){ }

        public ModeloCarro(MarcaCarro marca) :this(marca,new CategoriaCarro()) {}

        public ModeloCarro(MarcaCarro marca, CategoriaCarro categoria)
        {
            this.IdModeloCarro = 1;
            this.Marca = marca;
            this.Categoria = categoria;
        }
        public int IdModeloCarro { get; set; }
        public string Nome { get; set; }
        public MarcaCarro Marca { get; set; }
        public CategoriaCarro Categoria { get; set; }
    }
}
