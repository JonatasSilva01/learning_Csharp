using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string cod;
            string cod2;
            string numeroPeca;
            string numeroPeca2;
            string valorUnitario;
            string valorUnitario2;

            Console.WriteLine("Coloque o codigo da peça: ");
            cod = Console.ReadLine();

            Console.WriteLine("Coloque o codigo2 da peça: ");
            cod2 = Console.ReadLine();

            Console.WriteLine("Coloque o numero da peça: ");
            numeroPeca = Console.ReadLine();

            Console.WriteLine("Coloque o numero2 da peça: ");
            numeroPeca2 = Console.ReadLine();

            Console.WriteLine("Coloque o seu valor unitario peça: ");
            valorUnitario = Console.ReadLine();

            Console.WriteLine("Coloque o seu valor unitario2 peça: ");
            valorUnitario2 = Console.ReadLine();

            int codigo = int.Parse(cod);
            int codigo2 = int.Parse(cod2);
            int numero = int.Parse(numeroPeca);
            int numero2 = int.Parse(numeroPeca2);
            float preco = float.Parse(valorUnitario);
            float preco2 = float.Parse(valorUnitario2);

            if (codigo != 0 && codigo2 != 0 && numero != 0 && numero2 != 0 && preco != 0 && preco2 != 0)
            {

                Console.WriteLine($"Codigo: {codigo} e {codigo2}");

                float calculado = (numero + numero2) * preco + preco2;
                Console.WriteLine($"{numero}, {numero2}");

                Console.WriteLine($"O VALOR A PAGAR: R$ {calculado}");


                Console.ReadLine();
            }
            else Console.WriteLine("Volte sempre");


            Console.ReadLine();
        }
    }
}
