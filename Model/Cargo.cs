using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Cargo
    {
        public  int IdCargo { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public Setor Setor { get; set; }
        public bool Ativo { get; set; }


        public override string ToString()
        {
            return String.Format("Cargo: {0}, Descrição: {1}, Setor: {2}",this.Nome, this.Descricao, this.Setor.Nome);
        }

    }
}