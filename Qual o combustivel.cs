using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercicio_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustível o cliente deseja abastecer o veículo?");
            string tipo = Console.ReadLine().Trim().ToUpper();
            if (tipo == "1")
            {
                Console.WriteLine("Gasolina");
            }
            else if (tipo == "2")
            {
                Console.WriteLine("Etanol");
            }
            else if (tipo == "3")
            {
                Console.WriteLine("Diesel");
            }
            else
            {
                Console.WriteLine("Valor não reconhecido");
            }
        }

    }
}
