using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;

namespace Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public Funcionario Funcionario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int NivelDeAcesso { get; set; }

        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }
        public Usuario() {
            new Usuario("","");
        }
        
    }
}