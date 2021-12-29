using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresAndMatizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] {1, 2, 3, 4, 5 };
            string[] nomes = new string[4] { "Jonatas", "Nicolas", "Gustavo", "Jessica"};
            foreach(int i in numeros)
            {
                Console.WriteLine(numeros[i]);
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
