using System;
using System.Linq;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumVowels = 0;
            int sumCon = 0;
            int sum = 0;
            string vowels = "EeUuOoIiAa";

            int[] arrayOfSum = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    char currentLetter = name[j];
                    if (vowels.Contains(currentLetter))
                    {
                        sumVowels += currentLetter * name.Length;
                    }
                    else
                    {
                        sumCon += currentLetter / name.Length;
                    } 
                }

                sum = sumVowels + sumCon;
                arrayOfSum[i] = sum;
                sumVowels = 0;
                sumCon = 0;
                sum = 0;
            }
            Array.Sort(arrayOfSum);
            for (int i = 0; i < arrayOfSum.Length; i++)
            {
                Console.WriteLine(arrayOfSum[i]);
            }

        }
    }
}
