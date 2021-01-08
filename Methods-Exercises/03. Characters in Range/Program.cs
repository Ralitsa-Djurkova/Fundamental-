using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());

            PrintInBetween(firstSymbol, secondSymbol);
        }

        private static void PrintInBetween(char firstSymbol, char secondSymbol)
        {
            if(firstSymbol > secondSymbol)
            {
                char first = firstSymbol;
                firstSymbol = secondSymbol;
                secondSymbol = first;

            }

            for (int i = firstSymbol + 1; i < secondSymbol; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
