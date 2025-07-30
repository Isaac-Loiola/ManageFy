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

        public void Adicionar(T objeto)
        {
            contexto.Set<T>().Add(objeto);
            contexto.SaveChanges();
        }
        public void Listar(T classe)
        {
            contexto.Set<T>().ToList();
            contexto.SaveChanges();
        }
        public void ObterPor(Func<T, bool> condicao)
        {
            contexto.Set<T>().FirstOrDefault(condicao);
            contexto.SaveChanges();
        }
    }
}
