using CaixaEletronico.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    class SeguroDeVida : ITributavel
    {
        public double CalculaTributos()
        {
            return 42;
        }
    }
}
