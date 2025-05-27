using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Exercicio_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você estuda de manhã(M), de tarde(V) ou à noite(N) ?");
            string horario = Console.ReadLine().Trim().ToUpper();

            if (horario == "M")
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horario == "V")
            {
                Console.WriteLine("Boa Tarde!");
            }
            else if (horario == "N")
            {
                Console.WriteLine("Boa Noite!");
            }
            else
            {
                Console.WriteLine("Infomação invalida tente novamente");
            }
        }
    }
}
