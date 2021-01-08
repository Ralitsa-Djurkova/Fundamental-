using System;
using System.Linq;

namespace _10._MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            numbers = Math.Abs(numbers);
            Console.WriteLine(MultipleOfEvenAnOdd(numbers));
            

        }

        static int MultipleOfEvenAnOdd(int numbers)
        {
            return GetSumOfOddDigits(numbers, 0) * GetSumOfOddDigits(numbers, 1);
        }

        static int GetSumOfOddDigits(int numbers, int isOdd)
        {
            string number = numbers.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = int.Parse(number[i].ToString());

                if(currentDigit % 2 == isOdd)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }

        
    }
}
