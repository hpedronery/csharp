using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------BOXING-------------");

            int x = 20;
            Object obj = x;


            Console.WriteLine("--------------UNBOXING-------------");

            int y = 20;

            Object obj2 = y;
            int y = (int)obj;
        }
    }
}
