using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Models;

namespace CaixaEletronico.Util
{
    class GeradorDeContaPoupanca : TemplateGeradorDeConta
    {

        public GeradorDeContaPoupanca() : base()
        {
        }

        public GeradorDeContaPoupanca(GeradorDeConta proximoGerador) : base(proximoGerador)
        {
        }

        protected override Conta InstanciaDaContaCom(long numero, Cliente titular)
        {
            return new ContaPoupanca(numero, titular);
        }

        protected override string TipoDaConta()
        {
            return TiposDeConta.Poupanca.Descricao();
        }
    }
}
