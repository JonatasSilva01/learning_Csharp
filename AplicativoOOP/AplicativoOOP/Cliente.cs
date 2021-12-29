using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoOOP
{
    public class Cliente : Form1
    {
        /*
           esses são os atributos da classe
           onde tem as informações dos clientes.
        */

        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; } //Não pode inserir dados diretamente.
        public string rg { get; set; } //Não pode inserir dados diretamente.
        public string CEP { get; set; }

        // Podemos variar os CONSTRUTORES para deixar meu código mais dinamico e com mais opições.
        public Cliente(string Nome)
        {
            this.nome = Nome;
        }

        public Cliente(int Idade)
        {
            this.idade = Idade;
        }

        // Valores de inicio da variavel pra evitar
        // alguns problemas de falta de preenchimento de dados.
        public Cliente(string Nome = "Cliente Anonymous", int Idade = 0, string CPF = "1234567-x", string RG = "123456789-x", string endereco = "0000-0")
        {
            this.nome = Nome;
            this.idade = Idade;
            this.cpf = CPF;
            this.rg = RG;
            this.CEP = endereco;
        }

        /*
        public void CpfPessoa(string valor)
        {
            this.cpf = valor;
        }

        public void RgPessoa(string valor)
        {
            this.rg = valor;
        }
        */
        // Fazendo contrutores.

        /*
        public Cliente(string Nome,int Idade)
        {
            this.nome = Nome;
            this.idade = Idade;
        }
        */
       
        /*
            esse metodo ele cheka se o cliente
            é maior de idade ou não 
        */
        /*
            (Opcional) Crie mais um atributo na classe Cliente que guarda a idade da pessoa. No nosso caso,
            a idade é um número inteiro.

            Também crie um comportamento (método) com o nome EhMaiorDeIdade na classe Cliente que não recebe
            nenhum argumento e retorna um booleano indicando se o cliente é maior de idade ou não.
            Quando uma pessoa é maior de idade no Brasil? [X]
        */
        public bool EhMaiorDeIdade()
        {
            if (this.idade > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
