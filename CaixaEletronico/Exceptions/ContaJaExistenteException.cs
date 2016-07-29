using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Exceptions
{
    class ContaJaExistenteException : Exception
    {
        public ContaJaExistenteException(string message) : base(message)
        {
        }
    }
}
