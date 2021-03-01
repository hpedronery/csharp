using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------1-----------------------");
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("-----------------------2-----------------------");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------3-----------------------");

            List<string> list3 = new List<string>(list);
            list3.Remove("Alex");

            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------4------------------------");

            List<string> list4 = new List<string>(list);
            list4.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list4)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------5-----------------------");

            List<string> list5 = new List<string>(list);
            list5.RemoveAt(1);

            foreach (string obj in list5)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------------------6-----------------------");

            List<string> list6 = new List<string>(list);
            list6.RemoveRange(2, 2);

            foreach (string obj in list6)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
