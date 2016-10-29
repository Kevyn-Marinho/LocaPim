using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class MarcaCarro
    {
        public MarcaCarro() 
        {
            this.IdMarcaCarro = 1;
        }

        public int IdMarcaCarro { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
