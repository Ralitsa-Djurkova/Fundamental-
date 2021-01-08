using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var firstWord = text[0];
            var secondWord = text[1];

            var longest = firstWord;
            var shortest = secondWord;

            if(firstWord.Length < secondWord.Length)
            {
                longest = secondWord;
                shortest = firstWord;
            }

            var total = CharManipulator(longest, shortest);
            Console.WriteLine(total);
        }

        public static int CharManipulator(string longestWord, string shortestWord)
        {
            var sum = 0;
            for (int i = 0; i < shortestWord.Length; i++)
            {
                var manipulator = longestWord[i] * shortestWord[i];
                sum += manipulator;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }

            return sum;
        }
    }
}
