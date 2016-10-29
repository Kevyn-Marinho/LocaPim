using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public bool Funcionario { get; set; }
        public bool Cliente { get; set; }


    }   
}