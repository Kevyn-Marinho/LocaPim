using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    interface IDao<T> 
    {
        void Adicionar(T Obj);
        void SaveChanges();
        void Excluir(T Obj);
        IList<T> Listar();
    }
}
