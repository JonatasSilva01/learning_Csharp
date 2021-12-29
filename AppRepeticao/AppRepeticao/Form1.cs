using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepeticao
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
            double valorInvestivo = 1000.0;
            bool PodeInvertir = (valorInvestivo > 999.9);
            if (PodeInvertir)
            {
                for(int i = 1; i <= 12; i++) // (i++) -> (i += 1) -> (i = i + 1);
                {
                    valorInvestivo = valorInvestivo * 1.01;
                }
                MessageBox.Show($"Valor investido agora é: {valorInvestivo}");


            }
            else
            {
                MessageBox.Show("pelo menos o valor inicial tem que ser MAIOR que 1000R$");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorInvestido = 500.0;// Entrada do Usuario
            bool PodeInvestir = (valorInvestido > 999.9);
            int i = 1;

            while (i <= 12 && PodeInvestir)
            {
                valorInvestido = valorInvestido * 1.01;
                i++;// i += 1;
            }
            if(PodeInvestir)
            {
                MessageBox.Show($"Valor investido agora é {valorInvestido}R$");
            }else
            {
                MessageBox.Show($"Pelo menos tem que Investir 1000.0R$ para ter acrecimo no valor investido!");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            bool PodeInvestir = (valorInvestido > 999.9);
            int i = 1;
            // do while pelo menos ele repete o bloco de código 1 vez se a condição estiver verdadeira ele continua repetindo até que
            // a condição esteja favorecida.
            do
            {
                valorInvestido = valorInvestido * 1.01;
                i++; // i += 1;
            }
            while (i <= 12 && PodeInvestir);
            MessageBox.Show($"Valor Investido agora é {valorInvestido}");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ex -> resposta: (64)
            int total = 2;
            for(int i = 0; i<5; i++)
            {
                total = total * 2;
            }
            MessageBox.Show($"O Total foi --> {total}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = 0;
            for(int i = 1; i <= 1000; i++)
            {
                total = i + i;
            }
            MessageBox.Show($"Total: {total}");
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Todos os mutiplos de 3
            int Total = 100;
            for(int i = 1; i <= Total; i++)
            {
                if(i % 3 == 0)
                {
                    MessageBox.Show($"Numeros mutiplos de 3 ate o 100 -> {i}");
                }
            }
        }
        private bool eMultiploDe3(int x)
        {
            if ((x % 3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            /*
                Escreva um programa em C# que some todos os números de 1 a 100,
                pulando os múltiplos de 3. O programa deve imprimir o resultado final em um MessageBox. [x]
            */
            
            int soma = 0;
            for (int i = 1; i<=100; i++)
            {
                if(!eMultiploDe3(i))
                {
                    soma += i;
                }
            }
            MessageBox.Show($"A soma é {soma}");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /* 
             * Escreva um programa em C# que imprime todos os números
             que são divisíveis por 3 ou por 4 entre 0 e 3 [x] :D */
            int Total = 30;
            string divisivel3 = "";
            string divisivel4 = "";
            for (int i = 0; i <= Total; i++)// i += 1
            {
                if(i % 3 == 0) divisivel3 += $"{i}";
                if (i % 4 == 0) divisivel4 += $"{i}";
                MessageBox.Show($"Números Divisiveis por 3: {divisivel3}\nNumeros Divisiveis por 4: {divisivel4}");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            /*  
             *  Faça um programa em C# que imprima os fatoriais de 1 a 10. [x]

             */
            
            int numero = 10;
            double resultado = 1;
            while(numero != 1 && numero != 0)
            {
                resultado = resultado * numero;
                
                numero -= 1;
                MessageBox.Show($"{numero}\n{resultado}");
            }
            MessageBox.Show($"{resultado}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
             Faça um for que inicie uma variável n (número) como 1 e fatorial
             (resultado) como 1 e varia n de 1 até 10 [x]
            */
            int Fatorial = 1;
            for(int n = 1; n <= 10; n++)
            {
                Fatorial = Fatorial * n;
                MessageBox.Show($"Resultado: {Fatorial}\n Numero: {n}");
            }
            MessageBox.Show($"Resultado com total da fatorial = {Fatorial}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
             Faça um programa que imprima a seguinte tabela, usando fors encadeados [x]
            */
            string mult = "";
            for(int i = 1; i<=10; i++)
            {
                for (int k = 1; k <= i; k++) 
                {
                    mult += i * k + " ";
                    //MessageBox.Show($"{mult}"); // se quiser ver os numeros formando o encadeamento.
                }
                mult += "\n";
                MessageBox.Show($"{mult}"); // se quiser ver os encadeamentos por linha.
            }
            //MessageBox.Show($"{mult}"); // se quiser ver o encadeamento completo.
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
             Faça um programa em C# que imprima os primeiros números da série
             de Fibonacci até passar de 100. A série de Fibonacci é a seguinte:
             0, 1, 1, 2, 3, 5, 8, 13, 21 etc... Para calculá-la, o primeiro
             elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo elemento
             vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3). [x]
            L.P  n = n + p               
            L.A  0 + 1 + 1 + 2 + 3 + 5 + 8 + 13 + 21...
            */
            int num = 0;
            int prev = 0;
            for(int i = 1; i <= 20; i++)
            {
                if(num == 0)
                {
                    num = 1;
                }
                else
                {
                    int temp = num;
                    num = num + prev;
                    prev = temp;
                }
                MessageBox.Show("contagem do fibonacci\n"+num);
            }
            MessageBox.Show($"Resultado:\n{num}");
        }
    }
}
