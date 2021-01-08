using System;
using System.Linq;

namespace _09.PalindromIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int num = int.Parse(input);
            while (input != "END")
            {
                Console.WriteLine(IsPalindrom(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrom(string text)
        {
            var reversed = text.Reverse().ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                if(!(reversed[i] == text[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
