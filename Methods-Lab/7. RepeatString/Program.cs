using System;
using System.Linq;

namespace _7._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string result = RepeatString(input, num);
            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            string result = string.Empty;
           

            for (int i = 0; i < count; i++)
            {
                result += str;
            }

            return result.ToString();
        }
    }
}
