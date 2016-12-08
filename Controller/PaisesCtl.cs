using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class PaisController
    {
        public class PaissController
        {
            private EntidadesContext contexto = new EntidadesContext();

            public IList<Pais> Listar()
            {
                return new PaisDao(contexto).Listar();
            }

            public Pais BuscaPorId(int id)
            {
                if (id == null)
                {
                    throw new Exception("Informe o Id");
                }

                Pais pais = new PaisDao(contexto).BuscaPorId(id);
                if (pais == null)
                {
                    throw new Exception("Pais Não encontrado");
                }
                return pais;
            }

            public bool incluir(Pais pais)
            {
                try
                {
                    PaisDao dao = new PaisDao(contexto);
                    dao.Adicionar(pais);
                    dao.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }

            }

            public Pais Alterar(int id, Pais pais)
            {

                try
                {
                    PaisDao dao = new PaisDao(contexto);
                    dao.Editar(id, pais);
                    dao.SaveChanges();
                    return pais;
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
                    PaisDao dao = new PaisDao(contexto);
                    Pais pais = dao.BuscaPorId(id);
                    if (pais == null)
                    {
                        throw new Exception("Usuario não encontrado");
                    }
                    dao.Excluir(pais);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }

        }
    }
    }
