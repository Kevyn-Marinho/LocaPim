using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    class CarteiraDeMotoristaDao: IDao<CarteiraDeMotoristaDao>
    {
        private EntidadesContext contexto;

        public CarteiraDeMotoristaDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(CarteiraDeMotorista carteira)
        {
            try
            {
                contexto.CarteirasDeMotorista.Add(carteira);
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

        public void Excluir(CarteiraDeMotorista carteira)
        {
            try
            {
                contexto.CarteirasDeMotorista.Remove(carteira);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<CarteiraDeMotorista> Listar()
        {
            try
            {
                return contexto.CarteirasDeMotorista.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }    
    }
}
