using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class OperadoraCartaoDao : IDao<OperadoraCartao>
    {
        private EntidadesContext contexto;

        public OperadoraCartaoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(OperadoraCartao operadora)
        {
            try
            {
                contexto.OperadorasDeCredito.Add(operadora);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SaveChanges()
        {
            try
            {
                contexto.SaveChanges();

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Excluir(OperadoraCartao operadora)
        {
            try
            {
                contexto.OperadorasDeCredito.Remove(operadora);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public IList<OperadoraCartao> Listar()
        {
            try
            {
                return contexto.OperadorasDeCredito.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public OperadoraCartao BuscaPorId(int id)
        {
            return contexto.OperadorasDeCredito.FirstOrDefault(u => u.IdOperadoraCarta == id);
        }

        public void Editar(int id, OperadoraCartao operadora)
        {
            try
            {
                OperadoraCartao antiga = contexto.OperadorasDeCredito.Find(id);
                if(antiga == null)
                {
                    throw new Exception("Não foi possível localizar a operadora informada");
                }

                antiga = operadora;
                SaveChanges();
            }catch (Exception e)
            {
                throw e;
            }
        }
    }
}
