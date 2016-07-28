using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(long numero, Cliente titular) : base(numero, titular)
        {
        }

        public override void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
