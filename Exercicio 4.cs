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
            Console.Write("Digite os pontos da Julia: ");
            int pontosJulia = int.Parse(Console.ReadLine());

            Console.Write("Digite os pontos do Rafael: ");
            int pontosRafael = int.Parse(Console.ReadLine());

            string vencedor = (pontosJulia > pontosRafael) ? "Julia" :(pontosRafael > pontosJulia) ? "Rafael" :"Empate";
            Console.WriteLine("O vencedor é: {vencedor}");
        }

    }
}
