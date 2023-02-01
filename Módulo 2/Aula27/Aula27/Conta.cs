using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Saque(double value)
        {
            return Saldo - value;
        }
        public double Deposito(double value)
        {
            return Saldo + value;
        }

    }
}
