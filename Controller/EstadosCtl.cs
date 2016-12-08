using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class EstadosController
    { 
    private EntidadesContext contexto = new EntidadesContext();

    public IList<Estado> Listar()
    {
        return new EstadoDao(contexto).Listar();
    }

    public Estado BuscaPorId(int id)
    {
        Estado estado = new EstadoDao(contexto).BuscaPorId(id);
        if (estado == null)
        {
            throw new Exception("Cargo Não encontrado");
        }
        return estado;
    }

    public bool incluir(Estado estado)
    {
        try
        {
            EstadoDao dao = new EstadoDao(contexto);
            dao.Adicionar(estado);
            dao.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public Estado Alterar(int id, Estado estado)
    {

        try
        {
            EstadoDao dao = new EstadoDao(contexto);
            dao.Alterar(id, estado);
            dao.SaveChanges();
            return estado;
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
            EstadoDao dao = new EstadoDao(contexto);
            Estado estado = dao.BuscaPorId(id);
            if (estado == null)
            {
                throw new Exception("Usuario não encontrado");
            }
            dao.Excluir(estado);
        }
        catch (Exception e)
        {
            throw e;
        }

    }

}
}
