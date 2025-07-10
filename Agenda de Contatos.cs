using System;
using System.Collections.Generic;
using System.Linq;
class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
    }
}

class Program
{
    static void Main()
    {
        List<Contato> contatos = new List<Contato>();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Adicionar Contato");
            Console.WriteLine("2. Listar Contatos");
            Console.WriteLine("3. Buscar por Nome");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                contatos.Add(new Contato(nome, telefone, email));
                Console.WriteLine("Contato adicionado!");
            }
            else if (opcao == "2")
            {
                foreach (var contato in contatos)
                    Console.WriteLine(contato);
            }
            else if (opcao == "3")
            {
                Console.Write("Digite o nome a buscar: ");
                string busca = Console.ReadLine();
                var resultados = contatos.Where(c => c.Nome.ToLower().Contains(busca.ToLower()));

                foreach (var contato in resultados)
                    Console.WriteLine(contato);
            }
            else if (opcao == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
