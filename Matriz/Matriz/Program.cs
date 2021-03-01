using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor para n");
            int n = int.Parse(Console.ReadLine());
            double[,] mat = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("negative numbers " + count);
            /*Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank); //quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); //primeira dimensao
            Console.WriteLine(mat.GetLength(1)); // segunda dimensao*/
        }
    }
}
