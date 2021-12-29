using System;

namespace Banco
{
    public class Conta
    {
        public Conta(int Num = 1, double saldo = 1000)
        {
            this.Numero = Num;
            this.Saldo = saldo;
        }
        // Atributos da minha classe.
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; private set; }


        // acessando o saldo por metodos publicos.
        public void SaldoPessoa(double valor)// Estou colocando um valor inicial simulando uma conta normal
        {
            this.Saldo = valor;
        }

        public bool Retorna()
        {
            if(this.Saldo >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RetiraSaldo(double valor)
        {
            if(Saldo >= 0 )
            {
                Saldo -= valor;
            }else
            {
                Saldo = 0;
            }
        }

        public void Saca(double valor)
        {
            
            if(valor > 0)
            {
                this.RetiraSaldo(valor);
            }
            else
            {
                this.Saldo = Saldo;
            }
        }

        public void Deposita(double valor)
        {
            if(valor >= 0)
            {
                this.Saldo += valor;
            }
            else
            {
                this.Saldo = Saldo;
            }
        }
    }
}