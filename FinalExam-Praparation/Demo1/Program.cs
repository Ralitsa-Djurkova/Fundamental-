using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ");
            Dictionary<string, int> nameInformation = new Dictionary<string, int>();

            foreach (var name in names)
            {

                nameInformation.Add(name, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");
                int sum = 0;

                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }

                if (nameInformation.ContainsKey(name))
                {
                    nameInformation[name] += sum;
                }
                input = Console.ReadLine();
            }
            int count = 1;

            foreach (var kvp in nameInformation.OrderByDescending(c => c.Value))
            {
                string text = counter == 1 ? "st" : counter
            }
        }
    }
}
