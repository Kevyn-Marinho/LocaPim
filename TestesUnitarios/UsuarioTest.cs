using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Business;
namespace TestesUnitarios
{
    public class UsuarioTest
    {

        public void Adicionar()
        {
            Usuario usuario = new Usuario();
            usuario.Ativo = true;
            usuario.Funcionario = new Funcionario();
            usuario.Funcionario.Id = 1;
            usuario.Login = "kevyn.m";
            usuario.Senha = "qwer";
            usuario.NivelDeAcesso = 1;
            

        }
    }
}
