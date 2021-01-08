using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            if(number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (firstNumber[0] == '0')
            {
                firstNumber = firstNumber.Substring(1);
            }
            int remainder = 0;
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(firstNumber[i].ToString()) * number + remainder;
                remainder = 0;

                if(result > 9)
                {
                    remainder = result / 10;
                    result = result % 10;
                }
                sb.Append(result);
            }

            if(remainder != 0)
            {
                sb.Append(remainder);
            }

            StringBuilder finalResult = new StringBuilder();

            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }

            Console.WriteLine(finalResult);
        }
    }
}
