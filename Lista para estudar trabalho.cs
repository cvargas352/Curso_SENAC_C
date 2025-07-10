using System;
using System.Collections.Generic;
class Tarefa
{
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string descricao)
    {
        Descricao = descricao;
        Concluida = false;
    }

    public void MarcarComoConcluida()
    {
        Concluida = true;
    }

    public override string ToString()
    {
        return $"{Descricao} - {(Concluida ? "Concluída" : "Pendente")}";
    }
}

class Program
{
    static void Main()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas.Add(new Tarefa("Estudar C#"));
        tarefas.Add(new Tarefa("Fazer exercício da AEO"));
        tarefas.Add(new Tarefa("Entregar trabalho"));

        while (true)
        {
            Console.Clear();
            Console.WriteLine("TAREFAS:");
            for (int i = 0; i < tarefas.Count; i++)
                Console.WriteLine($"{i}. {tarefas[i]}");

            Console.WriteLine("\nDigite o número da tarefa para marcar como concluída (ou 'sair'):");
            string input = Console.ReadLine();
            if (input.ToLower() == "sair") break;

            if (int.TryParse(input, out int indice) && indice >= 0 && indice < tarefas.Count)
            {
                tarefas[indice].MarcarComoConcluida();
                Console.WriteLine("Tarefa marcada como concluída!");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}

