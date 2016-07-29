using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models.Contas
{
    public enum TiposDeConta
    {
        [Description("Conta Corrente")]
        ContaCorrente = 1,
        [Description("Poupança")]
        Poupanca = 2
    }
}
