using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Setor
    {
        public int IdSetor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Funcionario Gerente { get; set; }

    }
}