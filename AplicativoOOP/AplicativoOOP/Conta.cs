using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Alguns exercícios:
    
   1) Qual o comportamento do atributo abaixo:

    public int Numero { get; private set; }

    Resposta:    O número pode ser lido, mas não pode ser alterado por outras classes.

    2) Sobre o código abaixo é válido afirmar que...
    Conta c = new Conta();
    double valorADepositar = 200.0;
    c.Saldo += valorADepositar;

Resposta:   A operação de depósito não está encapsulada, podendo gerar problemas futuros de manutenção.


    O que é encapsulamento?

Resposta:    É esconder COMO a classe/método faz sua tarefa. Caso a regra mude, temos que alterar apenas um ponto do código.

    Qual o problema do atributo abaixo:

    public double Saldo { get; set; }

    Resposta: Transforme os atributos da classe Conta em propriedades. Permita que o saldo da conta seja lido,
    porém não seja alterado fora da classe, altere também o código das classes que utilizam a conta para que elas
    acessem as propriedades ao invés dos atributos diretamente.

 */


namespace AplicativoOOP
{
    public class Conta : Form1
    {
        /*
            - Eu Posso controlar o acesso dos atributos por metedos.

            - private só pode ser acessado dentro do seu próprio quadrado.

            - Public pode ser acessado por todos os quadrados de códigos.

            - O (get) serve para ler o que está dento do código podemos também privar só o (get)
              caso a linha inteira estiver privada precisamos mudar para o seguinte:
                
            public string nome { private get; set; }
            
            nesse código só o set é publico.

            - O (set) serve para inserção de dados por exemplo:
            programa:

            escreva seu nome ->>> JONATAS

            Bem vindo "JONATAS".

            Fim do programa.
            
            Entendeu?

            podemos controlar também essa inserção de dados e dexalo só para leitura.
        */
        public double saldo { get; private set; }
        public int numero { get; set; }
        private Cliente titular { get; set; }


        /*
         * Controlando o acesso para leitura com o Metodo
        public double PegaSaldo()
        {
            return this.saldo;
        }
        */
        public void ColocaSaldo(double valor)
        {
            this.saldo = valor;
        }
        

        public void Number(int Num)
        {
            this.numero = Num;
        }


        internal class AtualizadorDeContas
        {
            public void Atualizador(Conta conta)
            {

            }
        }



        /*public bool Saca(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }*/
        /*
        public bool Saca(double valor)
        /*
            (Opcional) Modifique o método Saca com validação para que ele devolva
            o valor true caso o saque tenha sido realizado com sucesso e FALSE caso
            contrário. Depois modifique o código do botão de teste da conta para que
            ele utilize o valor devolvido pelo método Saca para mostrar uma mensagem 
            para o usuário. Caso o saque seja bem sucedido, queremos mostrar a mensagem 
            "Saque realizado com sucesso", se não, mostraremos "Saldo insuficiente".[X] 
        */
        /*
            (Opcional) Agora altere o método Saca da classe Conta. Limite o valor do saque
            para R$ 200,00 caso o cliente seja menor de idade. [X]
        */
        /*
        {
            if (this.idade < 18)
            {
                if(valor <= 200)
                {
                    this.saldo -= valor;
                    MessageBox.Show($"Saque realizado com sucesso {this.saldo}R$");
                    return true;
                }
                else
                {
                    MessageBox.Show("Você é de menor, só pode sacar 200R$");
                    return false;
                }
            }
            if (valor <= 0 && this.idade > 18)
            {
                MessageBox.Show($"Voce precisa sacar um valor acima de 0");
                return true;
            }
            else
            {
                if (this.saldo >= valor)
                {
                    this.saldo -= valor;
                    MessageBox.Show($"Saldo realizado com sucesso! {this.saldo}R$");
                    return true;
                }
                else
                {
                    MessageBox.Show($"Saldo insuficiente! {this.saldo}R$");
                    return false;
                }
            }
        }
        public void Depositar(double valor)
        {
            //this.saldo += valor;
            if(valor <= 0)
            {
                MessageBox.Show("O valor de deposito é acima de 0");
            }
            else 
            {
                this.saldo += valor;
            }
        }
        public void Transfere(double valor, Conta destino)
        {
            /*(Opcional)Implemente o método Transfere que recebe o valor
             * da transferência e a conta de destino. Faça com que ele reutilize
             * as implementações dos métodos Saca e Deposita.
             * [x]
             */
        /*
            if (this.Saca(valor)) destino.Depositar(valor);
        }
        */
    }
}
