using CaixaEletronico.Models;
using CaixaEletronico.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        private Conta conta = new Conta(7921, new Cliente("Zeca Urubu", "650-92"));

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta(234, new Cliente("João das Couves", "893849"));
            c.Deposita(5000);

            Conta cc = new ContaCorrente(123, new Cliente("João das Laranjeiras", "783"));
            cc.Deposita(2500);

            Conta cp = new ContaPoupanca(789, new Cliente("Maria da Graça", "564356"));
            cp.Deposita(2500);

            TotalizadorDeContas totalizador = new TotalizadorDeContas();
            totalizador.Adiciona(c);
            totalizador.Adiciona(cc);
            totalizador.Adiciona(cp);

            Banco banco = new Banco();
            banco.Adiciona(c);
            banco.Adiciona(cc);
            banco.Adiciona(cc);

            MessageBox.Show(totalizador.SaldoTotal + "");
            MessageBox.Show(banco.TotalDeContas() + "");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Mostra(conta);
        }

        private void Mostra(Conta conta)
        {
            numeroTxt.Text = Convert.ToString(conta.Numero);
            SaldoTxt.Text = Convert.ToString(conta.Saldo);
            titularTxt.Text = conta.Titular.Nome;
        }

        private void efetuaDepositoBtn_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(valorParaOperacaoTxt.Text);
            conta.Deposita(valor);
            Mostra(conta);
            LimpaValorDeDeposito();
        }

        private void LimpaValorDeDeposito()
        {
            valorParaOperacaoTxt.Text = "";
        }

        private void efetuaSaqueBtn_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(valorParaOperacaoTxt.Text);
            conta.Saca(valor);
            Mostra(conta);
            LimpaValorDeDeposito();
        }
    }
}
