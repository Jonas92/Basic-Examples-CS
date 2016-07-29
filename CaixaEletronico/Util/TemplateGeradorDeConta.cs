using CaixaEletronico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Util
{
    abstract class TemplateGeradorDeConta : GeradorDeConta
    {
        private GeradorDeConta proximoGerador;

        public TemplateGeradorDeConta()
        {
        }

        public TemplateGeradorDeConta(GeradorDeConta gerador)
        {
            this.proximoGerador = gerador;
        }

        protected abstract string TipoDaConta();
        protected abstract Conta InstanciaDaContaCom(long numero, Cliente titular);

        public Conta GeraCom(long numero, Cliente titular, string tipoSelecionado)
        {
            if (TipoDaConta().Equals(tipoSelecionado))
                return InstanciaDaContaCom(numero, titular);

            else if (null != proximoGerador)
                return proximoGerador.GeraCom(numero, titular, tipoSelecionado);

            throw new Exception();
        }
        
    }
}
