using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new Conta();

            Conta contaBanco = new Conta();
            contaBanco.Numero = 1;
            Cliente cliente = new Cliente("Jonatas");
            contaBanco.Titular = cliente;

            TextoTitular.Text = contaBanco.Titular.Nome;

            TextoNumero.Text = Convert.ToString(contaBanco.Numero); // Convert.ToString faz uma conversão de numero para caractere
            TextoSaldo.Text = Convert.ToString(contaBanco.Saldo);

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = TextoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            if(valor >= 0)
            {
                if(this.conta.VerificaSeOClienteEstaComSaldoPositivoNoMomento())
                {
                    this.conta.Saca(valor);
                }
                else
                {
                    MessageBox.Show($"Sua conta não tem dinheiro suficiente");
                }
            }
            else
            {
                this.conta.Saca(0);
                MessageBox.Show("Digite um valor acima de 0");
            }
            TextoSaldo.Text = Convert.ToString(this.conta.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = TextoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            if(valor >= 0)
            {
                this.conta.Deposita(valor);
                MessageBox.Show("Valor Depositado com Sucesso!");
            }
            else
            {
                this.conta.Deposita(0);
                MessageBox.Show("só pode depositar acima de 0!");
            }
            TextoSaldo.Text = Convert.ToString(this.conta.Saldo);
            
        }
    }
}
