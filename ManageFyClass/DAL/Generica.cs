using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFyClass.DAL
{
    class Generico<T> where T : class
    {
        protected readonly Context contexto;

        public Generico(Context contexto)
        {
            this.contexto = contexto;
        }
    }
}
