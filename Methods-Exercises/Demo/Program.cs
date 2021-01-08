using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text.Length % 2 == 0)
            {
                string output = GetMiddleCharFromEveString(text);
                Console.WriteLine(output);
            }
            else
            {
                string oddOutput = GettMiddleCharFromOddString(text);
                Console.WriteLine(oddOutput);
            }
        }

        private static string GettMiddleCharFromOddString(string text)
        {
            int index = text.Length / 2;
            string chars = text.Substring(index, 1);
            return chars;
        }

        private static string GetMiddleCharFromEveString(string text)
        {
            int index = text.Length / 2;
            string chars = text.Substring(index - 1, 2);
            return chars;

        }
    }
}
