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
        private Conta[] conta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta = new Conta[3];

            this.conta[0] = new Conta();
            this.conta[0].Titular = new Cliente("Victor");
            this.conta[0].Numero = 1;

            this.conta[1] = new Conta();
            this.conta[1].Titular = new Cliente("Mauricio");
            this.conta[1].Numero = 2;

            this.conta[2] = new Conta();
            this.conta[2].Titular = new Cliente("osni");
            this.conta[2].Numero = 3;

            Conta contaBanco = new Conta();
            Cliente cliente = new Cliente();
            contaBanco.Numero = 1;
            contaBanco.Titular = cliente;

            TextoTitular.Text = contaBanco.Titular.Nome;

            TextoNumero.Text = Convert.ToString(contaBanco.Numero); // Convert.ToString faz uma conversão de numero para caractere
            TextoSaldo.Text = Convert.ToString(contaBanco.Saldo);

            foreach(Conta conta in conta)
            {
                comboContas.Items.Add($"Titular: {conta.Titular.Nome}");
            }

        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            //Recuperando o indice no saque
            int indice = Convert.ToInt32(comboContas.SelectedIndex);

            // e agora precisamos ler a posição correta do array.
            Conta selecionada = this.conta[indice];

            double valor = Convert.ToDouble(TextoValor.Text);
            if(valor >= 0)
            {
                if(selecionada.VerificaSeOClienteEstaComSaldoPositivoNoMomento())
                {
                    selecionada.Saca(valor);
                }
                else
                {
                    MessageBox.Show($"Sua conta não tem dinheiro suficiente");
                }
            }
            else
            {
                selecionada.Saca(0);
                MessageBox.Show("Digite um valor acima de 0");
            }
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            // Recuperando o indice da conta selecionada
            int indice = Convert.ToInt32(comboContas.SelectedIndex);

            Conta selecionada = this.conta[indice];
            double valor = Convert.ToDouble(TextoValor.Text);
            /*
            selecionada.Deposita(valor);

            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
            */
            if(valor >= 0)
            {
                selecionada.Deposita(valor);
                MessageBox.Show("Valor Depositado com Sucesso!");
            }
            else
            {
                selecionada.Deposita(valor);
                MessageBox.Show("só pode depositar acima de 0!");
            }
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
            

        }
        private void textoIndice_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textoIndice.Text);
            Conta selecionada = this.conta[indice];
            TextoNumero.Text = Convert.ToString(selecionada.Numero);
            TextoTitular.Text = selecionada.Titular.Nome;
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
        */

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = conta[indice];
            TextoTitular.Text = selecionada.Titular.Nome;
            TextoSaldo.Text = Convert.ToString(selecionada.Saldo);
            TextoNumero.Text = Convert.ToString(selecionada.Numero);
        }
    }
}
