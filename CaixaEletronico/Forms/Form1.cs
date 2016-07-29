using CaixaEletronico.Exceptions;
using CaixaEletronico.Models;
using CaixaEletronico.Models.Contas;
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
        private int quantidade;

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


        #region Adiciona novas contas

        public void AdicionaNova(Conta conta)
        {
            if (JaExisteEssa(conta))
                throw new ContaJaExistenteException("A conta " + conta.Numero + " já está cadastrada!");

            quantidade++;

            if (this.quantidade >= this.contas.Length)
                AumentaEspacoParaContas();

            this.contas[this.quantidade - 1] = conta;

            AdicionaContasNo(comboContas);
            AdicionaContasNo(comboContasParaTEDDOC);

        }

        #region Métodos auxiliares

        #region Verifica se a conta já existe

        private bool JaExisteEssa(Conta contaParam)
        {
            foreach (Conta conta in this.contas)
                if (conta.Equals(contaParam))
                    return true;

            return false;
        }

        #endregion

        #region Aumenta espaço para novas contas

        private void AumentaEspacoParaContas()
        {
            Conta[] backUpDeContas = this.contas;

            this.contas = new Conta[quantidade];

            for (int i = 0; i < backUpDeContas.Length; i++)
            {
                this.contas[i] = backUpDeContas[i];
            }
        }

        #endregion

        #endregion

        #endregion

        #region Cria contas iniciais

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

            quantidade = 3;
        }

        private void AdicionaContasNo(ComboBox combo)
        {
            combo.Items.Clear();

            foreach (Conta conta in contas)
                if (null != conta)
                    combo.Items.Add(conta.Titular.Nome);
        }

        #endregion

        #region Mostra informações da conta no form
        private void Mostra(Conta conta)
        {
            numeroTxt.Text = Convert.ToString(conta.Numero);
            SaldoTxt.Text = Convert.ToString(conta.Saldo);
            titularTxt.Text = conta.Titular.Nome;
        }
        #endregion

        #region Efetua depósito
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
        #endregion

        #region Efetua saque

        private void efetuaSaqueBtn_Click(object sender, EventArgs e)
        {

            try
            {
                contaSelecionada.Saca(ValorInserido());
                Mostra(contaSelecionada);
                MessageBox.Show("Saque efetuado com sucesso!");
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

        #endregion

        #region Efetua transferência

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                contaSelecionada.Transfere(ValorInserido(), PesquisaContaPor(comboContasParaTEDDOC.SelectedIndex));
                Mostra(contaSelecionada);
                MessageBox.Show("Transferência efetuada com sucesso!");
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

        #endregion

        #region Valida valor inserido pelo usuário

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

        #endregion

        #region Limpa campo para entrada de valores

        private void LimpaValor()
        {
            valorParaOperacaoTxt.Text = "";
        }

        #endregion

        #region Seleciona as contas noos combos

        #region Conta a ser mostrada
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaSelecionada = PesquisaContaPor(comboContas.SelectedIndex);
            Mostra(contaSelecionada);
        }
        #endregion

        #region Conta de destino para transferência

        private void comboContasParaTEDDOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            contaParaTEDDOC = PesquisaContaPor(comboContasParaTEDDOC.SelectedIndex);
        }

        #endregion

        private Conta PesquisaContaPor(int indiceDaContaNoCombo)
        {
            return contas[indiceDaContaNoCombo];
        }

        #endregion

        #region Direciona para o Form de cadastro

        private void novaContaBtn_Click(object sender, EventArgs e)
        {
            CadastroDeContasForm formularioDeCadastro = new CadastroDeContasForm(this);
            formularioDeCadastro.ShowDialog();
        }

        #endregion

        #region Remove Conta

        #region Ação do botão

        private void excluir_Conta_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = comboContas.SelectedIndex;
                Conta contaExcluida = contas[indice];
                RemoveContaDe(indice);
                AtualizarListagemDeContasSem(indice);
                MessageBox.Show("Conta " + contaExcluida.Numero + " excluída com sucesso!");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Por favor selecione uma conta para efetuar esta operação!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir a conta!" + ex.Message);
            }
        }

        #endregion

        #region Método de remoção de contas

        private void RemoveContaDe(int posicao)
        {

            if (posicao < 0)
                throw new IndexOutOfRangeException();

            this.contas[posicao] = null;
        }

        #endregion

        #region Atualizando a listagem e o form após a remoção da conta

        private void AtualizarListagemDeContasSem(int indice)
        {
            ReorganizaAsContasSemO(indice);
            AdicionaContasNo(comboContas);
            AdicionaContasNo(comboContasParaTEDDOC);
            LimpaFormulario();
            
        }

        #region Reorganiza o array de contas

        private void ReorganizaAsContasSemO(int indice)
        {
            for (int i = indice; i < this.contas.Length; i++)
            {
                if (this.contas[i] == null)
                {
                    if ((i + 1) < this.contas.Length)
                    {
                        this.contas[i] = this.contas[i + 1];
                        this.contas[i + 1] = null;
                    }

                }
            }
        }

        #endregion

        #region Limpa os campos após a exclusão

        private void LimpaFormulario()
        {
            numeroTxt.Text = "";
            SaldoTxt.Text = "";
            titularTxt.Text = "";
        }

        #endregion

        #endregion

        #endregion
    }
}
