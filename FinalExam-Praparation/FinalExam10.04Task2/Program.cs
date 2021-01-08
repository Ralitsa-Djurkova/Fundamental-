using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FinalExam10._04Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validWords = new List<string>();
            string input = Console.ReadLine();
            string pattern = @"([@,#])(?<word1>[a-zA-Z]{3,})(\1)(\1)(?<word2>[a-zA-Z]{3,})\1";

            MatchCollection matches = Regex.Matches(input, pattern);//имаме колекция от мачове

            foreach (Match match in matches)
            {
                var word1 = match.Groups["word1"].Value;
                var word2 = match.Groups["word2"].Value;

                var reveresed = String.Concat(word1.Reverse());

                if(reveresed == word2)
                {
                    validWords.Add($"{word1} <=> {word2}");
                }
                
            }

            if(matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if(validWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:\n" + string.Join(", ",validWords));
            }
        }
    }
}
