using CaixaEletronico.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca(long numero, Cliente titular) : base(numero, titular)
        {
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor + 0.1;
        }
    }
}
