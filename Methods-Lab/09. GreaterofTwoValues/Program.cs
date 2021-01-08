using System;
using System.Data;

namespace _09._GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(num1, num2));
                
            }
            if (input == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }
            if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetBigger(first, second));
            }

        }

        static int GetBigger(int num1, int num2)
        {
            int compare = num1.CompareTo(num2);

            if (compare > 0)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static char GerBigger(char first, char second)
        {
            int compare = first.CompareTo(second);

            if(compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetBigger(string first, string second)
        {
            int compare = first.CompareTo(second);

            if(compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
