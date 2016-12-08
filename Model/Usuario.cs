using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public int NivelDeAcesso { get; set; }

        public bool Ativo { get; set; }

        public int Id { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        public Usuario() { }

        public Usuario(String nomeUsuario, String senha) {
            this.Login = nomeUsuario;
            this.Senha = senha;
        }
    }
}