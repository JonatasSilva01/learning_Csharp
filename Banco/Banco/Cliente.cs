using System;
using System.Linq;

namespace Banco
{
    public class Cliente
    {
        //Atributos da minha classe
        public string Nome { get; set; }
        public int idade { get; set; }
        public string CPF { get; set; }
        public string documentos { get; set; }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.idade >= 18;
                var emancipado = this.documentos.Contains("emacipados");
                var possuiCPF = !string.IsNullOrEmpty(this.CPF);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }
        
        // Construtor
        /* 
          Caso os Clientes não escreverem seus Nomes,
          vai retornar um valor base do código informando que está vazio
        */
        public Cliente(string nomes = "vazio")
        { 
            this.Nome = nomes;
        }

        /* Comentário Ednaldo => Se aqui você quer setar apenas o nome do cliente, a variável nomes deveria ser nome, no singular. Se a intenção é colocar um nome completo, isso cabe dentro de uma String mesmo, como por exemplo, "Ednaldo Nicolau dos Santos"
        Tudo pode ser posto dentro de aspas pra ser como string, incluindo espaços.*/

        public static implicit operator string(Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}