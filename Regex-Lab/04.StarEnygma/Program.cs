using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnygma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            string pattern = @"@(?<planet>[A-Z][a-z]+)[^@\-!:>]*\:(?<population>\d+)[^@:!>\-]*!(?<attack>A|D)![^@:!>\-]*->(?<soldiers>\d+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int specialNumber = SpetioalLettersCount(encryptedMessage);
                string deccryptedMessege = DecryptMessage(encryptedMessage, specialNumber);

                Match match = Regex.Match(deccryptedMessege, pattern);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;

                    string attackType = match.Groups["attack"].Value;

                    if(attackType == "A")
                    {
                        attackPlanet.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanet.Add(planetName);
                    }
                }
            }


            PrintOutputforPlanet(attackPlanet, "Attacked");
            PrintOutputforPlanet(destroyedPlanet, "Destroyed");
        }
        private static void PrintOutputforPlanet(List<string> planets, string attackType)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");

            foreach (string planet in planets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        private static string DecryptMessage(string encrypted, int Key)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                char currentCh = encrypted[i];
                char decryptedCh = (char)(currentCh - Key);

                sb.Append(decryptedCh);
            }

            return sb.ToString();
        }

        private static int SpetioalLettersCount(string message)
        {

            char[] spetiolLetters = new char[] { 's', 't', 'r', 'a' };

            int spetiolLettersCount = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];

                if (spetiolLetters.Contains(Char.ToLower(currentChar)))
                {
                    spetiolLettersCount++;
                }
            }

            return spetiolLettersCount;
        }
    }
}
