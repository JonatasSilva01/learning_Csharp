﻿using System;

namespace Banco
{
    public class Conta
    {

        /*
        public Conta(int Num, double saldo)
        {
            this.Numero = Num;
            this.Saldo = saldo;
        }
        */
        // Atributos da minha classe.
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public Conta() { }
        public Conta(int numero)
        {
            this.Numero = numero;
        }
        public double Saldo { get; private set; }
        /*
         Protected só pode ser acessado pela própria classe e pelas classes filhas(as que herdam ela.)
         public double Saldo {get; protected set;}
         */
        public int Tipo { get; set; }


        // acessando o saldo por metodos publicos.
        public void SetSaldoPessoa(double valor)
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
            if(VerificaSeOClienteEstaComSaldoPositivoNoMomento())
            {
                
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                }
                else 
                {
                    System.Windows.Forms.MessageBox.Show("voce não tem saldo o suficiente!");
                }
                
                /*
                if(Tipo == ???)
                {
                    if (valor <= Saldo)
                    {
                        Saldo -= valor + 0.10;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("voce não tem saldo o suficiente!");
                    }
                }
                else
                {
                    if (valor <= Saldo)
                    {
                        Saldo -= valor;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("voce não tem saldo o suficiente!");
                    }
                }
                */
            }
            else
            {
                Saldo = 0;
            }
        }

        public virtual void Saca(double valor)
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
    public class TotalizadorDeContas
    {
        // Utilizado polimorfismo
        public double ValorTotal { get; private set; }
        public void Soma(Conta conta)
        {
            ValorTotal += conta.Saldo;
        }

        /*
         * O que eu acabei entendendo de Polimorfismo?
         
            para não usar muito repetição de código eu aprendi que somente as classes herdeiras
            podem utilizar varias funcionalidades e trazendo o conceitos de polimorfismo
            mesmo declarando somente a classe(pai) porque os herdeiros virão junto com a genetica do
            código. Isso ajuda a escrever códigos de qualidade
            pequenos e muito utilitario para o software e para outros programadores da equipe facilitando
            a agilidade do software e agilidade da equipe em resolver determidados problemas dentro de um
            determinado tempo.
        */
    }
}