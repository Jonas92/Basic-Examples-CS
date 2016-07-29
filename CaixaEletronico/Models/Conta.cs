using CaixaEletronico.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    public abstract class Conta
    {
        public long Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public Conta(long numero, Cliente titular)
        {
            this.Numero = numero;
            this.Saldo = 0;
            this.Titular = titular;
        }

        public abstract void Deposita(double valor);

        #region Saque

        public void Saca(double valor)
        {
            if (SaldoInsuficienteParaSacar(valor))
                throw new SaldoInsuficienteException("Saldo insuficiente!");

            this.Saldo -= valor;
        }

        private bool SaldoInsuficienteParaSacar(double valor)
        {
            return this.Saldo < valor;
        }

        #endregion

        #region Transferência

        public void Transfere(double valor, Conta destino)
        {
            if (this == destino)
                throw new ArgumentException("As contas de origem e destino devem ser diferentes!");

            this.Saca(valor);
            destino.Deposita(valor);
        }

        #endregion

        #region Métodos ToString, Equals e HashCode

        public override string ToString()
        {
            return "Número: " + this.Numero + " - Saldo: R$ " + this.Saldo;
        }

        public override bool Equals(object obj)
        {
            Conta outraConta = (Conta)obj;
            return this.Numero.Equals(outraConta.Numero);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
