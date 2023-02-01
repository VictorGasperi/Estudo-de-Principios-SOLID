using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27
{
    class ContaCorrente : Conta
    {
        public double Limite { get; set; }

        public double Juros(double value)
        {
            return Saldo - value;
        }
    }
}
