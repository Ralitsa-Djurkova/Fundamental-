using System;

namespace _04.ArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] numbersAsStrings = input.Split();

            int[] numbers = new int[numbersAsStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsStrings[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array[{i}]={numbers[i]}");
            }

        }
    }
}
