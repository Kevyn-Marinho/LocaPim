using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class FuncionariosController 
    { 
        private EntidadesContext contexto = new EntidadesContext();

    public IList<Funcionario> Listar()
    {
        return new FuncionarioDao(contexto).Listar();
    }

    public Funcionario BuscaPorId(int id)
    {
      Funcionario funcionario= new FuncionarioDao(contexto).BuscaPorId(id);
        if (funcionario == null)
        {
            throw new Exception("funcionario não encontrado");
        }
        return funcionario;
    }

    public bool incluir(Funcionario funcionario)
    {
        try
        {
            FuncionarioDao dao = new FuncionarioDao(contexto);
            dao.Adicionar(funcionario);
            dao.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public Funcionario Alterar(int id, Funcionario funcionario)
    {

        try
        {
           FuncionarioDao dao = new FuncionarioDao(contexto);
           dao.Editar(id, funcionario);
            dao.SaveChanges();
            return funcionario;
        }
        catch (Exception E)
        {
            throw E;
        }
    }

    public void Delete(int id)
    {
        try
        {
            FuncionarioDao dao = new FuncionarioDao(contexto);
            Funcionario funcionario = dao.BuscaPorId(id);
            if (funcionario == null)
            {
                throw new Exception("Funcionario não encontrado");
            }
            dao.Excluir(funcionario);
        }
        catch (Exception e)
        {
            throw e;
        }

    }

}
}
