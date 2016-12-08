using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Estados")]
    public class Estado
    {   [Key]
        public int IdEstado { get; set; }

        public String Uf { get; set; }

        public String Sigla { get; set; }

        [Required]
        public int IdPais { get; set; }
        public virtual Pais Pais { get; set; }

    }
}
