using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dao
{
    public class Dao<T>
    {
        private EntidadesContext contexto;

        public Dao(EntidadesContext context)
        {
            this.contexto = context;
        }
        
    }
}
