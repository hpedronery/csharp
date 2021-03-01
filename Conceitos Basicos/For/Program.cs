using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine(soma);
        }
    }
}
