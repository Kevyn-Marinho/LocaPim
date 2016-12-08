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
        public Usuario Login(Usuario usuario) 
        {
            //Hash hash = new Hash(SHA512.Create());
            //senha = hash.CriptografarSenha(senha);
            
            UsuarioDao dao = new UsuarioDao();
            
            usuario = dao.login(usuario);

            return usuario;
        }
            
   
    }
}
