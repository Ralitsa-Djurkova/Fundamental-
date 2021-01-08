using System;

namespace _11MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operation = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, @operation,b));
        }

        static double Calculate(int a, string @operation, int b)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
            }
            return result;
        }
    }
}
