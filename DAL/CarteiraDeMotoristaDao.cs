using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Dao
{
    public class CarteiraDeMotoristaDao: IDao<CarteiraDeMotorista>
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

        public CarteiraDeMotorista BuscaPorCnh(string cnh)
        {
            return contexto.CarteirasDeMotorista.FirstOrDefault(c => c.Cnh == cnh);
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

        public CarteiraDeMotorista BuscaCnh(string cnh)
        {
            return contexto.CarteirasDeMotorista.FirstOrDefault(c => c.Cnh == cnh);
        }

        public void Editar(string cnh, CarteiraDeMotorista carteira)
        {
            try
            {
                CarteiraDeMotorista antigo = BuscaCnh(cnh);

                if (antigo == null)
                {
                    throw new Exception("Não foi possível localizar a marca informada.");
                }

                antigo = carteira;
                contexto.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public CarteiraDeMotorista BuscaPorId(int id)
        {
            return contexto.CarteirasDeMotorista.Find(id);
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }    
    }
}
