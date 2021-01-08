using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(item => item == 5);

            Console.WriteLine(String.Join(' ',numbers));

        }
    }
}
