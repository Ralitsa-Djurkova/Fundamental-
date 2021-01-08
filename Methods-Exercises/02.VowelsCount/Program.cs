using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();

            int result = PrintVowels(word);
            Console.WriteLine(result);
            
        }

        public static int PrintVowels(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
