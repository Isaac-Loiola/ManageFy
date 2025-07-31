using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFyClass.DAL.DAO
{
    public class Transacao
    {
        public Transacao()
        {

        }

        public Transacao(int id, string descricao, double valor, string tipo, DateTime data, Categoria categoria)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            Data = data;
            Categoria = categoria;
        }

        public int Id { get; set; }
        public virtual Conta Conta { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime Data { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
