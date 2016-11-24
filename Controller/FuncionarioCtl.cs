using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dao;
using Model;

namespace Business
{
    public class FuncionarioCtl
    {
        private EntidadesContext contexto;
        public FuncionarioCtl()
        {
            this.contexto = new EntidadesContext();
        }

        public IList<Funcionario> Listar()
        {
            return new FuncionarioDao(contexto).Listar();
        }
       
    }
}
