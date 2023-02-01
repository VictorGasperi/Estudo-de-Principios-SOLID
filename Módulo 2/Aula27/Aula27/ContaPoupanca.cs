using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27
{
    class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; set; }
        public double CreditoJuros(double value)
        {
            return Saldo + value;
        }
    }
}
