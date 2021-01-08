using System;
using System.Text.RegularExpressions;

namespace _04.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string barcodePattern = @"(@#)(?<word>[A-Za-z][a-z]*[A-Z][a-z]*[A-z][\d]*)\1";
            string pattern = @"@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]@\#+";
            string numberPattern = @"\d*";

            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection barcodMatches = Regex.Matches(input, barcodePattern);
                MatchCollection numberMatches = Regex.Matches(input, numberPattern);
                if (barcodMatches.(input))
                {
                    Console.WriteLine($"Product group: {00}");
                }
                else if (barcodePattern.Contains(input))
                {
                    Console.WriteLine($"Product group: {numberMatches}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
