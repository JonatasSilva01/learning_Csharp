using System;

namespace Banco
{
    public class Cliente
    {
        //Atributos da minha classe
        public string Nome { get; set; }


        // Construtor
        /* 
          Caso os Clientes não escreverem seus Nomes,
          vai retornar um valor base do código informando que está vazio
        */
        public Cliente(string nomes = "vazio")
        { 
            this.Nome = nomes;
        }

        public static implicit operator string(Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}