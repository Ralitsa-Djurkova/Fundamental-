using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();


            Console.WriteLine(String.Join(", ", list));
            while (list.Count != 0)
            {
                list.RemoveAt(0);
                Console.WriteLine(String.Join(", ", list));

            }
        }
    }
}
