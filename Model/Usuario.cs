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
        public virtual Funcionario Funcionario { get; set; }
        [Required]
        public int IdFuncionario { get; set; }
        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }
        public Usuario() {
        }
        
    }
}