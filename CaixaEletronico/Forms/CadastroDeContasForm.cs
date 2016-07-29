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

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = nomeClienteTxt.Text;
            string cpf = cpfClienteTxt.Text;

            Cliente cliente = new Cliente(nome, cpf);

            long numero = Convert.ToInt32(numeroDaConta.Text);
            Cliente titular = cliente;
            Conta conta = new ContaCorrente(numero, titular);

            formularioPrincipal.AdicionaNova(conta);
        }
    }
}
