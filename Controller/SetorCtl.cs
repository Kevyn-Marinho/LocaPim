using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Dao;
namespace Business
{
    public class SetorCtl
    {
        public void Adicionar(Setor setor)
        {
            if (String.IsNullOrEmpty(setor.Nome))
                throw new Exception("Nome do setor não informado.");

            try
            {
                SetorDao dao = new SetorDao(setor);
                dao.Adicionar();
            }catch(Exception ex){
                throw ex;
            }
        }

        public void Editar(Setor setor)
        {
            try
            {
                SetorDao dao = new SetorDao(setor);
                dao.Editar();
            }catch(Exception ex){
                throw ex;
            }
        }

        public void Excluir(int idSetor)
        {
            if (idSetor <= 0)
                throw new Exception("Setor informado inexistente.");

            try
            {
                SetorDao dao = new SetorDao();
                dao.Excluir(idSetor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Setor> Listar()
        {
            try
            {
                SetorDao dao = new SetorDao();
                return dao.Listar();
            }catch(Exception ex){
                throw ex;
            }

        }

    }
}
