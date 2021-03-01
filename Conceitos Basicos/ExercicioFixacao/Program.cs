using System;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:\n" + produto1 + ", cujo preco e $ " + preco1 + "\n" + produto2 + ", cujo preco e $ " + preco2 + "\n");

            Console.WriteLine("Registro: " + idade + " anos de idade, codigo " + codigo + " e genero: " + genero + "\n");

            Console.WriteLine("Medida com oito casas decimais: " + medida + "\nArredondado (tres casas decimais): " + medida.ToString("F3") + "\n Separador decimal invariant culture: ");

        }
    }
}
