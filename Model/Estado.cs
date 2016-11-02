using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public String Uf { get; set; }
        public String Sigla { get; set; }
        public Pais Pais { get; set; }
    }
}
