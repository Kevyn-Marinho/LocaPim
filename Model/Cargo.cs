using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Cargo
    {
        private int IdCargo { get; set; }
        private string Descricao { get; set; }
        private string Nome { get; set; }
        private Setor Setor { get; set; }

    }
}