using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace Dao
{
    public class FuncionarioDao : IDao<Funcionario>
    {
        private EntidadesContext contexto;

        public FuncionarioDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }
        public void Adicionar(Funcionario funcionario)
        {
            try
            {
                contexto.Funcionarios.Add(funcionario);
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

        public void Excluir(Funcionario funcionario)
        {
            try
            {
                contexto.Funcionarios.Remove(funcionario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<Funcionario> Listar()
        {
            try
            {
                return contexto.Funcionarios.ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Editar(int id, Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Funcionario BuscaPorId(int id) {
            return contexto.Funcionarios.FirstOrDefault(u => u.Id == id);
        }

        public void FecharConexao()
        {
            contexto.Dispose();
        }    
    }
}
