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
        // Mecanismo de Herança deve ser utilizado com cuidado!

        // ContaPoupanca é uma classe filha ou uma subclasse.

        /*
            Quando se pensa em Herança o profissioanl pensa em como podemos reaproveitar tais códigos
            que podemos utilzar para não escrever muito e deixa-los muito menos complexos com fáceis
            entendimentos.
        */

        // O que é um override ?
        // Resposta minha: Para indicar que o método está sobrescrevendo um método da classe pai.

        // O que é um virtual ?
        // Resposta minha: Para permitir que o método seja sobrescrito.

        public override void Saca(double valor)
        {
            base.RetiraSaldo(valor + 0.10);
        }
        public ContaPoupanca(int numero) : base(numero) { }// Aplicando a referencia que é chamada dentro da classe pai


        public void CalculaRendimento()
        {

        }
        
    }
}
