using CaixaEletronico.Exceptions;
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

namespace CaixaEletronico.Forms
{
    public partial class Form1 : Form
    {
        private Conta[] contas = new Conta[3];
        private Conta contaSelecionada;
        private Conta contaParaTEDDOC;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CriaContas();
            AdicionaContasNo(comboContas);
            AdicionaContasNo(comboContasParaTEDDOC);

        }

        private void AdicionaContasNo(ComboBox combo)
        {
            foreach (Conta conta in contas)
                combo.Items.Add(conta.Titular.Nome);
        }

        private void CriaContas()
        {
            Conta c, cc, cp;

            c = new ContaCorrente(234, new Cliente("João das Couves", "893849"));
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
            try
            {
                contaSelecionada.Deposita(ValorInserido());
                Mostra(contaSelecionada);
                MessageBox.Show("Depósito efetuado com sucesso!");
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Você deve selecionar uma conta para efetuar esta operação!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na operação! Por favor, verifique novamente os dados informados e tente novamente");
            }
            finally
            {
                LimpaValor();
            }

        }

        private double ValorInserido()
        {
            var valor = 0d;

            try
            {
                valor = Convert.ToDouble(valorParaOperacaoTxt.Text);
            }
            catch (FormatException)
            {
                throw new ArgumentException("Valor inválido!");
            }

            if (valor <= 0)
                throw new ArgumentException("Valor inválido!");

            return valor;
        }

        private void LimpaValor()
        {
            valorParaOperacaoTxt.Text = "";
        }

        private void efetuaSaqueBtn_Click(object sender, EventArgs e)
        {

            try
            {
                contaSelecionada.Saca(ValorInserido());
                Mostra(contaSelecionada);
            }
            catch (SaldoInsuficienteException si)
            {
                MessageBox.Show(si.Message);
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Você deve selecionar uma conta para efetuar esta operação!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na operação! Por favor, verifique novamente os dados informados e tente novamente");
            }
            finally
            {
                LimpaValor();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaSelecionada = PesquisaContaPor(comboContas.SelectedIndex);
            Mostra(contaSelecionada);
        }

        private Conta PesquisaContaPor(int indiceDaContaNoCombo)
        {
            return contas[indiceDaContaNoCombo];
        }

        private void comboContasParaTEDDOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaParaTEDDOC = PesquisaContaPor(comboContasParaTEDDOC.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                contaSelecionada.Transfere(ValorInserido(), PesquisaContaPor(comboContasParaTEDDOC.SelectedIndex));
                Mostra(contaSelecionada);
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Você deve selecionar uma conta de origem e outra de destino para efetuar esta operação!");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na operação! Por favor, verifique novamente os dados informados e tente novamente");
            }
            finally
            {
                LimpaValor();
            }
        }
    }
}
