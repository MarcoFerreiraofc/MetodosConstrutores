using System;
using MetodosConstrutores.classes;

namespace Metodosconstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis:
            int codigo;
            string nome;
            string descricao;
            int emEstoque;

            Console.Clear();
            Console.WriteLine("Seja bem vindo ao mercado Markzera");
            Console.WriteLine("");

            Console.Write("Digite o código de do produto: ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            Console.Write("Digite o nome de do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite a descrição de do produto: ");
            descricao = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Digite o número de produtos em estoque: ");
            emEstoque = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Produto produto1 = new Produto(codigo, nome, descricao, emEstoque);
            Console.WriteLine("");

            Console.WriteLine("INFORMAÇÕES DO PRODUTO CADASTRADO:");
            Console.WriteLine("");
            Console.WriteLine($"CÓDIGO: {produto1.Codigo}");
            Console.WriteLine($"NOME: {produto1.Nome}");
            Console.WriteLine($"DESCRIÇÃO: {produto1.Descricao}");
            Console.WriteLine($"ESTOQUE: {produto1.EmEstoque}");
        }
    }
}