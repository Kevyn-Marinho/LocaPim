using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    interface IDao 
    {
        void Adicionar();
        void Editar();
        void Excluir(int id);
    }
}
