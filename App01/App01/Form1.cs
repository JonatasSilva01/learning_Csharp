using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 500;
            string mensagem = "";
            bool resposta = true;
            double imposto;

            if (resposta) { 
                if(valor <= 999)
                {
                    imposto = 2.0;
                    double ValorNotaFiscal = valor * imposto;
                    double Valorfinal = ValorNotaFiscal - valor;
                    mensagem = $"valor = {ValorNotaFiscal} imposto = {Valorfinal}";
                    MessageBox.Show(mensagem);
                } 
                else if (valor > 999 && valor <= 2999)
                {
                    imposto = 2.5;
                    double ValorNotaFiscal = valor * imposto;
                    double Valorfinal = ValorNotaFiscal - valor;
                    mensagem = $"valor = {ValorNotaFiscal} imposto = {Valorfinal}";
                    MessageBox.Show(mensagem);
                }
                else if(valor >= 3000 && valor <= 6999)
                {
                    imposto = 2.8;
                    double ValorNotaFiscal = valor * imposto;
                    double Valorfinal = ValorNotaFiscal - valor;
                    mensagem = $"valor = {ValorNotaFiscal} imposto = {Valorfinal}";
                    MessageBox.Show(mensagem);
                }
                else if(valor >= 7000)
                {
                    imposto = 3.0;
                    double ValorNotaFiscal = valor * imposto;
                    double Valorfinal = ValorNotaFiscal - valor;
                    mensagem = $"valor = {ValorNotaFiscal} imposto = {Valorfinal}";
                    MessageBox.Show(mensagem);
                }
            }
            
        }
    }
}
