using System;

namespace _8.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            double result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string cur = input[i];
                char firstLetter = cur[0];
                char lastLetter = cur[cur.Length - 1];

                double number = double.Parse(cur.Substring(1, cur.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstLetter));
                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastLetter));

                if((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    number = number / (firstElementIndex + 1);
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }
                if((int) lastLetter >= 65 && (int)lastLetter <= 90)
                {
                    number = number - (secondElementIndex + 1);
                }
                else
                {
                    number = number + (secondElementIndex + 1);
                }
                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
