using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>(?:[1-3]?[0-9])|(?:3[0-1]))-(?<month>[A-Z][a-z]{2})-(?<year>[0-9]{4})";
            string whitespace = @"\s+";
            var regex = new Regex(pattern);
            // string text = "Today is 25-Nov-2020";
            //text =  regex.Replace(text, "today");
            string text = "2   4 3  1   6   4   3         8";

            int[] arr = Regex.Split(text, whitespace).Select(int.Parse).ToArray();
            Console.WriteLine(text);
        }
    }
}
