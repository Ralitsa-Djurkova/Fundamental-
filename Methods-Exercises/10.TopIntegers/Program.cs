using System;

namespace _10.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            DivisibleByEight(numbers);
        }

        static void DivisibleByEight(int numbers)
        {
            for (int i = 0; i <= numbers; i++)
            {
                string currentNumber = i.ToString();
                bool IsOddDigit = false;
                int SumOfDigit = 0;

                foreach (var currNum in currentNumber)
                {
                    int parseNumber = (int)currNum;

                    if(parseNumber % 2 == 1)
                    {
                        IsOddDigit = true;
                    }

                    SumOfDigit += parseNumber;
                }

                if(SumOfDigit % 8 == 0 && IsOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
