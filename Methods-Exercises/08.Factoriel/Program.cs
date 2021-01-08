using System;

namespace _08.Factoriel
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            decimal result = (CalculatetFactorielNum1(num1) / CalculatetFactorielNum1(num2));
            Console.WriteLine($"{result:f2}");
        }

        static decimal CalculatetFactorielNum1(int num)
        {
            decimal factoriel = 1;

            for (int i = 1; i <= num; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }

       
    }
}
