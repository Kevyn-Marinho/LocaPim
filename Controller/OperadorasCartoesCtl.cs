using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class OperadorasCartoesController
    {
        private EntidadesContext contexto = new EntidadesContext();

          public IList<OperadoraCartao> Listar()
            {
                return new OperadoraCartaoDao(contexto).Listar();
            }

            public OperadoraCartao BuscaPorId(int id)
            {
        
                OperadoraCartao operadoraCartao = new OperadoraCartaoDao(contexto).BuscaPorId(id);
                if (operadoraCartao == null)
                {
                    throw new Exception("Operadora de Cartao Não encontrado");
                }
                return operadoraCartao;
            }

            public bool incluir(OperadoraCartao operadoraCartao)
            {
                try
                {
                    OperadoraCartaoDao dao = new OperadoraCartaoDao(contexto);
                    dao.Adicionar(operadoraCartao);
                    dao.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }

            }

 public void Editar(int id, OperadoraCartao operadoraCartao)
  {
   try
   {
        OperadoraCartaoDao dao = new OperadoraCartaoDao(contexto);
   
        dao.Editar(id, operadoraCartao);
        dao.SaveChanges();
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
    OperadoraCartaoDao dao = new OperadoraCartaoDao(contexto);
    OperadoraCartao operadoraCartao = dao.BuscaPorId(id);
    if (operadoraCartao == null)
    {
    throw new Exception("Operadora não encontrado");
    }
    dao.Excluir(operadoraCartao);
    }
    catch (Exception e)
    {
    throw e;
    }

            }

        }
    }
