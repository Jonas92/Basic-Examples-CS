using CaixaEletronico.Models;
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
            Cliente firstClient = new Cliente("Jonas", "030.678");

            Conta conta = new Conta(121212, firstClient);

            conta.Deposita(200);

            MessageBox.Show(conta.Saldo + " - " + conta.Titular.Nome);
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
