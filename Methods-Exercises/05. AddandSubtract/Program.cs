﻿using System;

namespace _05._AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thurdNumber = int.Parse(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber, thurdNumber);

            Console.WriteLine(sum);
        }

        private static int Sum(int firstNumber, int secondNumber, int thurdNumber)
        {
            int sumFirstAndSecond = firstNumber + secondNumber;
            return Subtract(sumFirstAndSecond, thurdNumber);
        }

        private static int Subtract(int sumFirstAndSecond, int thurdNumber)
        {
            return sumFirstAndSecond - thurdNumber;
        }
    }
}
