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
        public IList<Funcionario> Listar()
        {
            return new FuncionarioDao().Listar();
        }
       
    }
}
