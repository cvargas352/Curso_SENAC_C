using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua nota: ");
            double nota = double.Parse(Console.ReadLine());
            {
                if (nota <= 5)
                {
                    Console.WriteLine("Em recuperação");
                }
                else if (nota > 5 && nota <= 6.9)
                {
                    Console.WriteLine("Regular");
                }
                else if (nota >= 7 && nota <= 8.9)
                {
                    Console.WriteLine("Bom");
                }
                else if (nota >= 9 && nota <= 10)
                {
                    Console.WriteLine("Excelente");
                }
                else
                {
                    Console.WriteLine("Nota invalida");
                }
            } 
       } 
       } 
       } 