using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;

namespace Business
{
    public class CargoCtl
    {
        public void Adicionar(Cargo cargo)
        {
            if (String.IsNullOrEmpty(cargo.Nome))
                throw new Exception("Nome do cargo não informado.");

            if (String.IsNullOrEmpty(cargo.Descricao))
                throw new Exception("Descrição das atividades não informado.");

            if (String.IsNullOrEmpty(cargo.Setor.IdSetor.ToString()))
                throw new Exception("Setor não informado.");

            try
            {
                CargoDao dao = new CargoDao(cargo);
                dao.Adicionar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Editar(Cargo cargo)
        {
            try
            {
                CargoDao dao = new CargoDao(cargo);
                dao.Editar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int idCargo)
        {
            if (idCargo <= 0)
                throw new Exception("Cargo informado inexistente.");

            try
            {
                CargoDao dao = new CargoDao();
                dao.Excluir(idCargo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Cargo> Listar()
        {
            try
            {
                CargoDao dao = new CargoDao();
                return dao.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
