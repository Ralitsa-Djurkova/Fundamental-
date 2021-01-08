using System;

namespace DemoTask08
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double result = 0.0;
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char firstLatter = curr[0];
                char lastLatter = curr[curr.Length - 1];

                double number = double.Parse(curr.Substring(1, curr.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstLatter));
                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastLatter));

                if((int)firstLatter >= 65 && (int)firstLatter <= 90)
                {
                    number = number / (firstElementIndex + 1);
                }
                else
                {
                    number = number * (firstElementIndex + 1);
                }
                if((int)lastLatter >= 65 && (int)lastLatter <= 90)
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
