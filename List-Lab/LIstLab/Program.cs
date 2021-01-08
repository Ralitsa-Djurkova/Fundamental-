using System;
using System.Collections.Generic;

namespace LIstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(55);
            numbers.Add(65);
            numbers.Add(45);

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Count);
        }
    }
}
