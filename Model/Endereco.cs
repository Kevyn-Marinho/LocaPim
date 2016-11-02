using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Endereco
    {
        public int IdEndereco { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public Cidade Cidade { get; set; }
        
    }
}
