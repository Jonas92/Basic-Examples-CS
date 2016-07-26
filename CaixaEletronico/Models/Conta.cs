﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    class Conta
    {
        public long Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public Conta(long numero, Cliente titular)
        {
            this.Numero = numero;
            this.Saldo = 0;
            this.Titular = titular;
        }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}