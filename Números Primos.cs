using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para verificar se é primo: ");
            int numero = int.Parse(Console.ReadLine());
            int divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisores++;
                }
            }

            if (numero > 1 && divisores == 2)
            {
                Console.WriteLine($"{numero} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{numero} NÃO é um número primo.");
            }
        }
    }
}
