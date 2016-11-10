using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    class OperadoraCartaoDao : IDao<OperadoraCartao>
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
    }
}
