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

        public FuncionarioDao()
        {
            this.contexto = new EntidadesContext();
        }
        public void Adicionar(Funcionario funcionario)
        {
            contexto.Funcionarios.Add(funcionario);
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Funcionario funcionario)
        {
            contexto.Funcionarios.Remove(funcionario);
        }

        public IList<Funcionario> Listar()
        {
           return contexto.Funcionarios.ToList();
        }
    }
}
