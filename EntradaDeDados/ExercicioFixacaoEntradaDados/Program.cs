using System;

namespace ExercicioFixacaoEntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quantosQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha): ");

            string[] v = Console.ReadLine().Split(' ');
            string lastName = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            Console.WriteLine("Nome: {0}\nQuantos quartos tem em casa: {1}\nO preco do produto é: {2}\n" +
                "Ultimo nome: {3}\nIdade: {4}\nAltura: {5} ", name, quantosQuartos, preco, lastName, idade, altura);

        }
    }
}
