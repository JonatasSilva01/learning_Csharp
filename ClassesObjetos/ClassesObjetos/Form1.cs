using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesObjetos.Conta;

namespace ClassesObjetos
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
        
        class Conta
        {
            // atributos
            public int numero;
            public string titular;
            public double saldo;

            public bool Saca(double valor)
            // metodo dentro da classe
            // this pode ser usado como uma chave universal.
            {
                if (this.saldo >= 250.0)
                {
                    this.saldo -= valor;
                    return true;
                }else 
                { 
                    return false;
                }
            }

            public bool Deposito(double valor)
            {
                if(valor != 0 && valor > 0)
                {
                    this.saldo += valor;
                    return true;
                } 
                else
                {
                    return false;
                }
            }

            public void Transfere(double valor, Conta destino)
            {
                if (this.Saca(valor))
                {
                    destino.Deposito(valor);
                }
            }

        }

       

        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void enviar_Click(object sender, EventArgs e)
        {
            
            Conta c = new Conta();
            c.titular = textBox1.Text;
            c.saldo = double.Parse(textBox2.Text);
            double sacar = double.Parse(textBox4.Text);
            double deposito = double.Parse(textBox5.Text);
            c.numero = int.Parse(textBox3.Text);

            bool deuCerto = c.Saca(sacar);
            bool deuCerto2 = c.Deposito(deposito);

            if(deuCerto2) MessageBox.Show($"Deposito feito com sucesso!");
            else MessageBox.Show($"O deposito precisa ter um valor acima de 0");

            if (deuCerto) MessageBox.Show("Saque Realizado com sucesso");
            else MessageBox.Show("Saldo insuficiente");


            

            MessageBox.Show($"Nome: {c.titular}\nSaldo: {c.saldo}\nNumero {c.numero}");
            

        }

         
    }
}
