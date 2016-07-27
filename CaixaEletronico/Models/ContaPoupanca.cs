using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca(long numero, Cliente titular) : base(numero, titular)
        {
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor + 0.1;
        }
    }
}
