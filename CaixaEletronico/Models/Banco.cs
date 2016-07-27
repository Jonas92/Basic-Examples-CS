using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico.Models
{
    class Banco
    {
        public Conta[] contas = new Conta[1];

        private int quantidade;

        public void Adiciona(Conta conta)
        {
            this.contas[this.quantidade] = conta;
            this.quantidade++;

            if (PrecisoDeMaisEspaco())
                EfetuaBackUpDeContasExistentesECriaEspacoParaNovasContas();
                 
        }

        private void EfetuaBackUpDeContasExistentesECriaEspacoParaNovasContas()
        {
            Conta[] backUpDasContas = contas;
            contas = new Conta[EspacoParaNovasContas()];
            Transfere(backUpDasContas);
        }

        private void Transfere(Conta[] backUpDasContas)
        {
            for (int i = 0; i < backUpDasContas.Length; i++)
                if (contas[i] == null)
                    contas[i] = backUpDasContas[i];

        }

        private bool PrecisoDeMaisEspaco()
        {
            if (contas.Length == quantidade)
                return true;
            return false;
        }

        private int EspacoParaNovasContas()
        {
            return contas.Length + 10;
        }

        public int TotalDeContas()
        {
            int TotalDeContasCadastradas = 0;

            foreach (Conta conta in contas)
                if (null != conta)
                    TotalDeContasCadastradas++;

            return TotalDeContasCadastradas;
        }
        
    }
}
