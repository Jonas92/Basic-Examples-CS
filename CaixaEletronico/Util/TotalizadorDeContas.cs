﻿using CaixaEletronico.Models;
using CaixaEletronico.Models.Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Util
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void Adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }
}
