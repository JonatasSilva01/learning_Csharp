using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                Conta ContaJonatas = new Conta();
                ContaJonatas.titular = "Jonatas";
                ContaJonatas.numero = 1;
                ContaJonatas.saldo = 2000.0;

                Conta ContaNicolas = new Conta();
                ContaNicolas.titular = "Nicolas";
                ContaNicolas.numero = 2;
                ContaNicolas.saldo = 110.0;

                Conta Mauricio = new Conta();
                Mauricio.numero = 3;
                Mauricio.titular = "Mauricio";
                Mauricio.saldo = 100.0;

                Conta Mauricio2 = new Conta();
                Mauricio.numero = 3;
                Mauricio.titular = "Mauricio";
                Mauricio.saldo = 100.0;
            */
            /*
            Cliente Jonatas = new Cliente();
            Jonatas.nome = "Jonatas";
            Jonatas.idade = 20;
            Jonatas.cpf = "123456789-2";
            Jonatas.rg = "123456789-4";
            Jonatas.endereco = "Rua Olegario paiva, 490";
            */
            /*
            Conta ContaJonatas = new Conta();
            ContaJonatas.titular = Jonatas;
            ContaJonatas.numero = 1;
            ContaJonatas.saldo = 2000.0;
            Conta c = new Conta();
            c.numero = 1; // get --> é a leirtura set ---> é a inserção consigo ler e escrever porque nem o get e o set está private.
            MessageBox.Show($"Numero: {c.numero}");
            c.ColocaSaldo(1200);
            MessageBox.Show($"saldo: {c.saldo}");
            */

            // o nome disso é um Initializer
            /*
                O Initializer é um bloco de código que serve para inicializar
                as propriedades públicas do objeto. 
            */


            Cliente Gui = new Cliente();
            MessageBox.Show($"Nome: {Gui.nome}\nNome: {Gui.cpf}\nNome: {Gui.rg}\nNome: {Gui.idade}\nNome: {Gui.CEP}\n");
            

            /*
            if (ContaJonatas.titular.EhMaiorDeIdade())
            {
                MessageBox.Show(
                    $"Maior de Idade \n"+
                    $"Nome: {ContaJonatas.titular.nome} \n" +
                    $"Idade: {ContaJonatas.titular.idade} \n" +
                    $"cpf: {ContaJonatas.titular.cpf} \n" +
                    $"RG: {ContaJonatas.titular.rg} \n" +
                    $"Endereco: {ContaJonatas.titular.endereco} \n");
            }
            else
            {

                MessageBox.Show(
                    $"Menor de idade \n"+
                    $"Nome: {ContaJonatas.titular.nome} \n" +
                    $"Idade: {ContaJonatas.titular.idade} \n" +
                    $"cpf: {ContaJonatas.titular.cpf} \n" +
                    $"RG: {ContaJonatas.titular.rg} \n" +
                    $"Endereco: {ContaJonatas.titular.endereco} \n");
            }
            */
            



            //MessageBox.Show($" Nome: {ContaJonatas.titular.nome}\n CPF: {ContaJonatas.titular.cpf}\n RG: {ContaJonatas.titular.rg}\n Endereço: {ContaJonatas.titular.endereco}");



            /*
            MessageBox.Show($"Nome: {ContaJonatas.titular}\nNumero: {ContaJonatas.numero}\n Saldo: {ContaJonatas.saldo}");
            MessageBox.Show($"Nome: {ContaNicolas.titular}\nNumero: {ContaNicolas.numero}\n Saldo: {ContaNicolas.saldo}");

            //ContaNicolas.Depositar(100);
            MessageBox.Show($"Nome: {ContaNicolas.titular}\nSaldo: {ContaNicolas.saldo}");

            //ContaJonatas.Depositar(500);
            MessageBox.Show($"Nome: {ContaJonatas.titular}\nSaldo: {ContaJonatas.saldo}");

            if(Mauricio == Mauricio2)
            {
                MessageBox.Show("São Inguais!!");
            }
            else
            {
                MessageBox.Show("São diferentes!!");
            }

            Conta Mauricio4 = new Conta();
            Mauricio4.saldo = 2000.0;

            Conta copia = Mauricio4;
            copia.saldo = 3000.0;

            MessageBox.Show("Mauricio = " + Mauricio4.saldo);
            MessageBox.Show("Cópia = " + copia.saldo);

            //ContaNicolas.Transfere(10.0, ContaJonatas);
            MessageBox.Show($"Nome: {ContaNicolas.titular}\n Saldo: {ContaNicolas.saldo}");
            MessageBox.Show($"Nome: {ContaJonatas.titular}\n Saldo: {ContaJonatas.saldo}");

            MessageBox.Show($"SALDO: {ContaJonatas.saldo},\n NOME: {ContaJonatas.titular}");
            */

        }
    }
}
