using System;
using System.Collections.Generic;
using Dao;
using Model;

namespace Business
{
    public class CarteiraDeMotoristaController
    {
        private EntidadesContext contexto = new EntidadesContext();

        public IList<CarteiraDeMotorista> Listar()
        {
            return new CarteiraDeMotoristaDao(contexto).Listar();
        }

        public CarteiraDeMotorista BuscaCnh(string cnh)
        {
            CarteiraDeMotorista Carteirademotorista = new CarteiraDeMotoristaDao(contexto).BuscaCnh(cnh);

            if (Carteirademotorista == null)
            {
                throw new Exception("Carteira de Motorista não encontrada");
            }
            return Carteirademotorista;
        }

        public CarteiraDeMotorista BuscaPorCnh(string cnh)
        {
            return new CarteiraDeMotoristaDao(contexto).BuscaPorCnh(cnh);
        }

        public bool incluir(CarteiraDeMotorista Carteirademotorista)
        {
            try
            {
                CarteiraDeMotoristaDao dao = new CarteiraDeMotoristaDao(contexto);
                dao.Adicionar(Carteirademotorista);
                dao.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Editar(string cnh, CarteiraDeMotorista carteirademotorista)
        {

            try
            {
                CarteiraDeMotoristaDao dao = new CarteiraDeMotoristaDao(contexto);

                dao.Editar(cnh, carteirademotorista);
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
                CarteiraDeMotoristaDao dao = new CarteiraDeMotoristaDao(contexto);
                CarteiraDeMotorista carteirademotoristaantiga = dao.BuscaPorId(id);
                if (carteirademotoristaantiga == null)
                {
                    throw new Exception("Carteira de Motorista não encontrada");
                }
                dao.Excluir(carteirademotoristaantiga);
                //kevin rever
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}