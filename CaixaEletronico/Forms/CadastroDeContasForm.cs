﻿using CaixaEletronico.Exceptions;
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

namespace CaixaEletronico.Forms
{
    public partial class CadastroDeContasForm : Form
    {
        private Form1 formularioPrincipal;

        public CadastroDeContasForm(Form1 formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        #region Cadastra a nova conta

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Conta conta = ValoresInseridosNoForm();
                formularioPrincipal.AdicionaNova(conta);
                MessageBox.Show("Conta " + conta.Numero + " cadastrada com sucesso!");
                LimpaFormDeCadastro();
            }
            catch (ContaJaExistenteException cje)
            {
                MessageBox.Show(cje.Message);
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar a nova conta!");
            }
        }

        #endregion

        #region Limpa campos do formulário, após cadastrar

        private void LimpaFormDeCadastro()
        {
            nomeClienteTxt.Text = "";
            cpfClienteTxt.Text = "";
            numeroDaConta.Text = "";
        }

        #endregion

        #region Devolve uma instânca de conta pronta para ser salva

        #region Recupera valores inseridos no formulário de cadastro

        private Conta ValoresInseridosNoForm()
        {
            try
            {
                string nome = nomeClienteTxt.Text;
                string cpf = cpfClienteTxt.Text;

                Cliente cliente = new Cliente(nome, cpf);

                long numero = Convert.ToInt32(numeroDaConta.Text);
                Cliente titular = cliente;
                return InstanciaDeContaCom(numero, titular);
            }
            catch (Exception)
            {
                throw new ArgumentException("Valores inconsistentes, por favor" +
                    "verifique os dados informados e tente novamente!");
            }
        }

        #endregion

        #region Devolve uma conta, do tipo específico desejado

        private Conta InstanciaDeContaCom(long numero, Cliente titular)
        {
            string tipo = tipoContaCombo.SelectedItem.ToString();

            if(TiposDeConta.ContaCorrente.Descricao().Equals(tipo))
                return new ContaCorrente(numero, titular);

            if (TiposDeConta.Poupanca.Descricao().Equals(tipo))
                return new ContaPoupanca(numero, titular);

            throw new Exception();
        }

        #endregion

        #endregion

        private void CadastroDeContasForm_Load(object sender, EventArgs e)
        {
            tipoContaCombo.Items.Add("Conta Corrente");
            tipoContaCombo.Items.Add("Poupança");

            //foreach(TiposDeConta tipoDeConta in TiposDeConta.values())
        }
    }
}
