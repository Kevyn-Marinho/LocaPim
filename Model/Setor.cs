using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Setores")]
    public class Setor
    {
     
        [Key]
        public int IdSetor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return String.Format("Setor: {0}, Descrição: {1}, Ativo: {2}",this.Nome, this.Descricao,this.Ativo);
        }
    }
}