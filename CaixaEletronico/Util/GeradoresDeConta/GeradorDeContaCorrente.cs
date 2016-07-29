using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaixaEletronico.Models;
using CaixaEletronico.Models.Contas;

namespace CaixaEletronico.Util.GeradoresDeConta
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
