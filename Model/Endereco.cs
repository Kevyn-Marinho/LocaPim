using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        [Required]
        public Cidade Cidade { get; set; }
        public int IdCidade { get; set; }
        [Required]
        public Pessoa Pessoa { get; set; }
        public int IdPessoa { get; set; }
        
    }
}
