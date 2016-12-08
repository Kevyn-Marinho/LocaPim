using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class CidadeController
    { 
     private EntidadesContext contexto = new EntidadesContext();

    public IList<Cidade> Listar()
    {
        return new CidadeDao(contexto).Listar();
    }

    public Cidade BuscaPorId(int id)
    {
        if (id == null)
        {
            throw new Exception("Informe o Id");
        }

        Cidade cidade = new CidadeDao(contexto).BuscaPorId(id);
        if (cidade == null)
        {
            throw new Exception("Cidade não encontrada");
        }
        return cidade;
    }

    public bool incluir(Cidade cidade)
    {
        try
        {
            CidadeDao dao = new CidadeDao(contexto);
            dao.Adicionar(cidade);
            dao.SaveChanges();
            return true;
        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public Cidade Alterar(int id, Cidade cidade)
    {

        try
        {
            CidadeDao dao = new CidadeDao(contexto);
            dao.Editar(id, cidade);
            dao.SaveChanges();
            return cidade;
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
            CidadeDao dao = new CidadeDao(contexto);
            Cidade cidade = dao.BuscaPorId(id);
            if (cidade == null)
            {
                throw new Exception("Cidade não encontrada");
            }
            dao.Excluir(cidade);
        }
        catch (Exception e)
        {
            throw e;
        }

    }

        public Cidade BuscaPorNome(string nomeCidade)
        {
            return new CidadeDao(contexto).BuscaPorNome(nomeCidade);
        }
    }
}
