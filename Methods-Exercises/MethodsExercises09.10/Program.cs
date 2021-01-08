using System;

namespace MethodsExercises09._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNumber, secondNumber, thurdNumber);

        }

        public static void PrintSmallestNumber(int firstNumber, int secondNumber, int thurdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thurdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber < firstNumber && secondNumber < thurdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thurdNumber < firstNumber && thurdNumber < secondNumber)
            {
                Console.WriteLine(thurdNumber);
            }
            else
            {
                Console.WriteLine(firstNumber);
            }
        }
    }
}
