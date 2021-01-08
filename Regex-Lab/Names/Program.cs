using System;
using System.Text.RegularExpressions;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            Console.WriteLine(regex.IsMatch(input));
            Console.WriteLine(regex.Match(input));
        }
    }
}
