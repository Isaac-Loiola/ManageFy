using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFyClass.DAL.DAO
{
    public class Categoria 
    {
       public Categoria()
        {

        }

        public Categoria(int id, string nome, string tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; } // Recorrente  - variavel
    }
}
