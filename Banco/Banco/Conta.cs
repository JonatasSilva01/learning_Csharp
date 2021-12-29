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
        public void SetSaldoPessoa(double valor)// Estou colocando um valor inicial simulando uma conta normal
        {
            this.Saldo = valor;
        }

        /* Comentário Ednaldo => Dica de algo que você vai ver sempre.....nesse caso pelo que entendi, o método SaldoPessoa não retorna nada, ele serve apenas para dar um novo valor ao saldo.
        Ou seja, serve para SETAR um novo saldo.

        A dica é: 

        Se você vai pegar algum valor através de um método, por exemplo, se você quisesse pegar o Saldo da Pessoa, o método seria GetSaldoPessoa
        Como ao invés de pegar, você vai atribuir um valor, por isso pode ser  SetSaldoPessoa

        Repare que usei SET e GET 

        Uma dica boa é, sempre por os verbos de acordo com a tua intenção, por exemplo:

        Se você quer atualizar o saldo, seria => UpdateSaldoPessoa
        Se você quer pegar o saldo, seria => GetSaldoPessoa
        Se você quer por um novo saldo, seria => SetSaldoPessoa
        Se você quer deletar o saldo, seria => DeleteSaldoPessoa */

        public bool VerificaSeOClienteEstaComSaldoPositivoNoMomento()
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

        /*Comentário Ednaldo => Esse método não está sendo usado....
        Mas se a ideia for devolver algo informando se o valor do saldo atual é maior que 0, você pode mudar o nome do método para VerificaSeOClienteEstaComSaldoPositivoNoMomento por exemplo.
        Repare que o nome novo é grande, mas ele é muito descritivo, e da pra saber exatamente o que ele faz, só chamando ele, sem precisar conhecer detalhes de implementação interna do método pra entender o que ele faz.
        Isso é uma dica de código limpo e expressivo.
        */

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