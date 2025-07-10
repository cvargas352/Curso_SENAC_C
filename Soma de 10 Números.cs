using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            Console.WriteLine($"A soma dos 10 números é: {soma}");
        }
    }
}
