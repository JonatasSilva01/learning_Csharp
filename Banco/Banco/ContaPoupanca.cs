using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        /*
            Quando uma classe é definida com o :, dizemos que ela herda da outra (Conta)
            e por isso ela ganha todos os atributos e métodos da outra classe. Por exemplo, se ContaPoupanca herdar
            de Conta, isso quer dizer que ela terá Numero, Saldo, Titular, Saca() e Deposita() automaticamente, sem
            subclasse ou classe filha da classe Conta e que Conta é uma classe base ou classe pai da ContaPoupanca precisar
            fazer nada. Dizemos que a classe ContaPoupanca é uma
        */

        public override void Saca(double valor)
        {
            this.RetiraSaldo(valor + 0.10);
        }

        
    }
}
