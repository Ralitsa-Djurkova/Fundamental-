using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2.DestinationMapper
{
    class Program
    {


        static void Main(string[] args)
        {
            List<string> planets = new List<string>();
            string information = Console.ReadLine();
            string pattern = @"(=|\/)(?<planetName>[A-Z][A-Za-z]{2,})\1";

            int sum = 0;
            MatchCollection matches = Regex.Matches(information, pattern);

            foreach (Match match in matches)
            {
                var planetName = match.Groups["planetName"].Value;
                planets.Add(planetName);
                sum += match.Groups["planetName"].Value.Length;
            }

            Console.WriteLine($"Destinations: " + string.Join(", ", planets));
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
