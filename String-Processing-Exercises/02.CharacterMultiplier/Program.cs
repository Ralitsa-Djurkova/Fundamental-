using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split();

            var firstWord = tokens[0];
            var seconWord = tokens[1];

            var longestWord = firstWord;
            var shortestWord = seconWord;

            if (firstWord.Length < seconWord.Length)
            {
                longestWord = seconWord;
                shortestWord = firstWord;
            }

            var total = charManipulater(longestWord, shortestWord);
            Console.WriteLine(total);
        }

       public static int charManipulater(string longestWird, string shortestword)
        {
            var sum = 0;

            for (int i = 0; i < shortestword.Length; i++)
            {
                var multiplay = longestWird[i] * shortestword[i];
                sum += multiplay;
            }

            for (int i = shortestword.Length; i < longestWird.Length; i++)
            {
                sum += longestWird[i];
            }
            return sum;
        }
    }
}
