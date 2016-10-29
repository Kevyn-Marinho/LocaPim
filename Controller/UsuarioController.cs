﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Security.Cryptography;
namespace Controller
{
    public class UsuarioController
    {
        public Usuario Login(string nomeUsuario, string senha) 
        {
            //Hash hash = new Hash(SHA512.Create());
            //senha = hash.CriptografarSenha(senha);
            
            Usuario usuario = new Usuario(nomeUsuario.ToUpper(), senha);
            
            usuario.Funcionario = new Funcionario();
            usuario.Funcionario.idFuncionario = 0;
            
            usuario.NivelDeAcesso = 0;
            UsuarioDAL dao = new UsuarioDAL();
            
            usuario = dao.login(usuario);

            return usuario;
        }



    }
}
