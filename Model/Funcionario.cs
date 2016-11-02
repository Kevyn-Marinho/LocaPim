using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Funcionario : Pessoa
    {
        public bool Usuario { get; set; }
        public Cargo Cargo { get; set; }

    }
}