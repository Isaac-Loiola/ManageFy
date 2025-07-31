using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFyClass.DAL.DAO
{
    public class Conta
    {
        public Conta()
        {

        }
        public Conta(string id, double saldo)
        {
            Id = id;
            Saldo = saldo;
        }

        public string Id { get; set; }
        public double Saldo { get; set; }
    }
}
