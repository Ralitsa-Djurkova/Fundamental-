using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string text = Console.ReadLine();
            string pattern = @"(?<=\s)(?<user>[A-Za-z0-9]+[.-]*\w*)*@(?<host>[a-z]+?([.-][a-z]*)*(\.[a-z]{2,}))";


            var matches = Regex.Matches(text, pattern);

            Console.WriteLine(string.Join(Environment.NewLine, matches));
        }
    }
}
