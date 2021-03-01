using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe n");
            int n = int.Parse(Console.ReadLine());
            Pensionato[] vect = new Pensionato[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent # {0}:", (i + 1));
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[i] = new Pensionato(name, email, room);
            }
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < n; i++)
            {
                if (i != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }

        }
    }
}
