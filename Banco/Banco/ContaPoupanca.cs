using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        // Metodos
        public void Saca(double valor)
        {

            if (valor > 0)
            {
                this.RetiraSaldo(valor + 0.10);
            }
            else
            {
                this.Saldo = Saldo;
            }
        }

        public void Deposita(double valor)
        {
            if (valor >= 0)
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
