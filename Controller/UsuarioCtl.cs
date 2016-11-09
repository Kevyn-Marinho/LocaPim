using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;
using System.Security.Cryptography;
namespace Business
{
    public class UsuarioCtl
    {
        public Usuario Login(string nomeUsuario, string senha) 
        {
            //Hash hash = new Hash(SHA512.Create());
            //senha = hash.CriptografarSenha(senha);
            
            Usuario usuario = new Usuario(nomeUsuario.ToUpper(), senha);
            
            usuario.Funcionario = new Funcionario();
            usuario.Funcionario.Id = 0;
            
            usuario.NivelDeAcesso = 0;
            UsuarioDao dao = new UsuarioDao();
            
            usuario = dao.login(usuario);

            return usuario;
        }
            
   
    }
}
