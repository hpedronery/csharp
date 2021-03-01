using System;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            prod.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + prod);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            prod.AdicionarProdutos(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + prod);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            prod.RemoverProdutos(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados do produto: " + prod);

        }
    }
}
