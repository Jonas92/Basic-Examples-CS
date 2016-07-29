using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Models;

namespace CaixaEletronico.Util
{
    class GeradorDeContaCorrente : TemplateGeradorDeConta
    {
        public GeradorDeContaCorrente() : base()
        {
        }

        public GeradorDeContaCorrente(GeradorDeConta proximoGerador) : base(proximoGerador)
        {
        }

        protected override Conta InstanciaDaContaCom(long numero, Cliente titular)
        {
            return new ContaCorrente(numero, titular);
        }

        protected override string TipoDaConta()
        {
            return TiposDeConta.ContaCorrente.Descricao();
        }
    }
}
