using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoWin1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mensagem = "Olá mundo!";
            var Mundo = "Curso de C# da Caelum";
            var Caelum = "Nenhuma das Opções";
            MessageBox.Show(mensagem);
            MessageBox.Show(Mundo);
            MessageBox.Show(Caelum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numeroDaConta = 1;
            double saldo = 100.0;
            double ValorDoSaque = 10.0;
            saldo -= ValorDoSaque;
            //saldo = saldo - ValorDoSaque;
            
            MessageBox.Show($"Numero da conta: {numeroDaConta} O SALDO DA CONTA APÓS O SAQUE É: {saldo} R$");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor = 1;
            //long valorGrande = valor; conversão perigosa
            /*Forçando o C# a compilar o valor de um inteiro dentro de um short*/
            short valorPequeno = (short)valor; // conversão perigosa chamada -> casting

            //string mensagem = "Olá ";
            //string nome = "Jonatas";

            //MessageBox.Show(mensagem + nome);

            int idade = 20;
            string mensagem = "sua idade é: " + idade;

            MessageBox.Show(mensagem);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crie 3 variáveis com as idades dos seus melhores amigos e/ou familiares
            // Em seguida, pegue essas 3 idades e calcule a média delas. Exiba o resultado em um MessageBox.
     
            int IdadeDoNicolas = 25;
            int IdadeDoTim = 48;
            int IdadeDaEdilene = 50;

            float Media = (IdadeDaEdilene + IdadeDoNicolas + IdadeDoTim) / 3;
            

            MessageBox.Show($"a Media será: {Media}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
                Repare o (int). Estamos "forçando" a conversão do double para um inteiro.
                Qual o valor de piQuebrado nesse caso?

                a) 3.14
                b) 0
                c) 3
             */
            float pi = 3.14f; 
            int piQuebrado = (int)pi;// Forçando uma quebra no Pi

            MessageBox.Show("Pi Quebrado = " + piQuebrado);
            /*
                Resposta:
                 c) 3
                Porque ao forçar um numero real para inteiro ele
                acaba esquecendo os pontos flutuntes e foca somente
                nos numeros inteiros
            */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, a1, a2;

            a = 1;
            b = 2;
            c = 3;

            delta = Math.Sqrt(b * b) - Math.Sqrt(4*a*c);
            a1 = (-b - delta)/(2*a);
            a2 = (-b + delta)/(2*a);

            MessageBox.Show("Resultado de a1 = "+a1);
            MessageBox.Show("Resultado de a2 = "+a2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 5;
            double valorSaque = 10;
            bool PodeSacar = (saldo >= valorSaque);

            if(PodeSacar)
            {
                saldo -= valorSaque;
                MessageBox.Show("VALOR DO SAQUE REALIZADO COM SUCESSO");
                MessageBox.Show("-"+valorSaque+"R$ SALDO ATUAL: "+ saldo);
            }
            else
            {
                MessageBox.Show($"SALDO INSULFICIENTE!\n Saldo: {saldo}R$");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double saldo = 5;
            double saldoSaque = 10;
            bool PodeSacar = (saldo >= saldoSaque);

            if (PodeSacar)
            {
                MessageBox.Show("Saque realizado com Sucesso!!");
            }
            else
            {
                MessageBox.Show("Infelizmente está sem saldo!!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*
             Em alguns casos, podemos ter mais de duas decisões possíveis. O banco pode, por exemplo, decidir
             que contas com saldo menor que R$ 1000 pagam 1% de taxa de manutenção,contas com saldo entre
             R$ 1000 e R$ 5000 pagam 5% e contas com saldo maior que R$ 5000 pagam 10%.
            */

            double saldo = 5500;
            double taxa;
            bool ContasMenores = (saldo < 1000);
            bool ContasMedianas = (saldo > 1000 && saldo <= 5000);
            bool ContasAltas = (saldo > 5000);

            if(ContasMenores)
            {
                taxa = 0.01;
                MessageBox.Show($"Saldo da sua conta: {saldo}\nTaxa de Manutenção {taxa}%");
            }
            else if(ContasMedianas)
            {
                taxa = 0.05;
                MessageBox.Show($"Saldo da sua conta: {saldo}\nTaxa de Manutenção {taxa}%");
            }
            else if (ContasAltas)
            {
                taxa = 0.10;
                MessageBox.Show($"Saldo da sua conta: {saldo}\nTaxa de Manutenção {taxa}%");
            }
            else
            {
                taxa = 0.01;
                MessageBox.Show($"Saldo da sua conta: {saldo}\nTaxa de Manutenção {taxa}%");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
                O C# vai processar as condições na ordem, até encontrar uma que seja satisfeita.
                Ou seja, na segunda condição do código, só precisamos verificar que saldo é menor
                ou igual a R$ 5000, pois se o C# chegar nessa condição é porque ele não entrou no
                primeiro if, isto é, sabemos que o saldo é maior ou igual a R$ 1000 nesse ponto.

                Com base nisso, qual vai ser a mensagem exibida pelo código seguinte? 
            */

            double saldo = 500.0;
            if(saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo");
            }
            else if(saldo< 1000000.0)
            {
                MessageBox.Show("Você é um bom Clente"); // essa será exibida!!
            }
            else
            {
                MessageBox.Show("Você é milionario!!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int Idade = 10;
            bool Brasileira = true;


        }
    }
}
