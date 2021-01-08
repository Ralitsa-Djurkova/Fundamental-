using System;
using System.Text.RegularExpressions;

namespace _03.Data
{
    class Program
    {
        private static object match;

        static void Main(string[] args)
        {

             MatchCollection dates =  Regex.Matches(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Z a-z]{3})\k<separator>(\d{4})");

            foreach (Match date in dates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups[1]}");
            }

        }
    }
}
