using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
namespace Controller
{
    public class FuncionarioController
    {
        public FuncionarioController(){}
        public void Incluir(Funcionario funcionario)
        {
            DAL.FuncionarioDAL dao = new FuncionarioDAL(funcionario);
            dao.Incluir();
        }

        public Funcionario Buscar(Funcionario funcinoario)
        {
            FuncionarioDAL dao = new FuncionarioDAL(funcinoario);
            return dao.Buscar();
        }

        public void Alterar(Funcionario funcionario) 
        {
            FuncionarioDAL dao = new FuncionarioDAL(funcionario);
            dao.Alterar();
        }

        public void Excluir(Funcionario funcionario)
        {
            FuncionarioDAL dao = new FuncionarioDAL(funcionario);
            dao.Excluir();
        }

        public IList<Funcionario> Listar() { 
            FuncionarioDAL dao = new FuncionarioDAL(new Funcionario());
            return dao.Listar();
        }
    }
}
