using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Models;

namespace CaixaEletronico.Util
{
    interface GeradorDeConta
    {
        Conta GeraCom(long numero, Cliente titular, string tipo);
    }
}
