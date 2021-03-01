﻿using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("---------------------------------------------------");

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            Console.WriteLine("---------------------------------------------------");

            int b = 10;
            int quadruple;
            Calculator.Quadruple(b, out quadruple);
            Console.WriteLine(quadruple);

        }
    }
}
