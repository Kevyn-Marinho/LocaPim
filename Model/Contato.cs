using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Contato
    {
        private int IdContato { get; set; }
        private Pessoa Pessoa { get; set; }
        private TipoDeContato TipoContato { get; set; }
        private string telefone { get; set; }
        private bool Ativo { get; set; }
    }
}
