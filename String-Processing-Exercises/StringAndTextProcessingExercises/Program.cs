using System;
using System.Collections.Generic;
using System.Linq;

namespace StringAndTextProcessingExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(", ");

            for (int i = 0; i < input.Length; i++)
            {
                var cur = input[i];
                if (isValid(cur))
                {
                    Console.WriteLine(cur);
                }
            }
           
           
        }

        public static bool isValid(string current)
        {
            return current.Length >= 3 &&
                current.Length <= 16 &&
                current.All(c => char.IsLetterOrDigit(c)) ||
                current.Contains("-") || current.Contains("_");
        }
    }
}
