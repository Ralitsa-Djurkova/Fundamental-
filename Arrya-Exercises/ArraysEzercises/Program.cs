using System;
using System.Diagnostics.CodeAnalysis;

namespace ArraysEzercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine().Split();
            var array2 = Console.ReadLine().Split();

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if(array1[j] == array2[i])
                    {
                        Console.Write(array2[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
