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
        private Conta[] contas = new Conta[3];
        private Conta contaSelecionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CriaContas();
            AdicionaContasNoCombo();

        }

        private void AdicionaContasNoCombo()
        {
            foreach (Conta conta in contas)
                comboContas.Items.Add(conta.Titular.Nome);
        }

        private void CriaContas()
        {
            Conta c, cc, cp;

            c = new Conta(234, new Cliente("João das Couves", "893849"));
            c.Deposita(5000);

            cc = new ContaCorrente(123, new Cliente("João das Laranjeiras", "783"));
            cc.Deposita(2500);

            cp = new ContaPoupanca(789, new Cliente("Maria da Graça", "564356"));
            cp.Deposita(2500);

            contas[0] = c;
            contas[1] = cc;
            contas[2] = cp;
        }

        private void Mostra(Conta conta)
        {
            numeroTxt.Text = Convert.ToString(conta.Numero);
            SaldoTxt.Text = Convert.ToString(conta.Saldo);
            titularTxt.Text = conta.Titular.Nome;
        }

        private void efetuaDepositoBtn_Click(object sender, EventArgs e)
        {
            if (null == contaSelecionada)
                MessageBox.Show("Por favor, selecione uma conta antes de realizar qualquer operação!");
            else
            {
                double valor = Convert.ToDouble(valorParaOperacaoTxt.Text);
                contaSelecionada.Deposita(valor);
                Mostra(contaSelecionada);
                LimpaValorDeDeposito();
            }
        }

        private void LimpaValorDeDeposito()
        {
            valorParaOperacaoTxt.Text = "";
        }

        private void efetuaSaqueBtn_Click(object sender, EventArgs e)
        {
            if (null == contaSelecionada)
                MessageBox.Show("Por favor, selecione uma conta antes de realizar qualquer operação!");
            else
            {
                double valor = Convert.ToDouble(valorParaOperacaoTxt.Text);
                contaSelecionada.Saca(valor);
                Mostra(contaSelecionada);
                LimpaValorDeDeposito();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceDaContaNoCombo = comboContas.SelectedIndex;
            contaSelecionada = contas[indiceDaContaNoCombo];
            Mostra(contaSelecionada);
        }
    }
}
