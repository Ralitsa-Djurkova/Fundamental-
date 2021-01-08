using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            var result = numbers.Where(x => x > numbers.Average()).ToList();

            if(result.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(" ",result.OrderByDescending(x=>x).Take(Math.Min(5, result.Count))));


        }
    }
}
