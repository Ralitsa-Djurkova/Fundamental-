using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            List<int> player2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            while (player1.Count != 0 && player2.Count != 0)
            {
                int firstPlayerCard = player1[0];
                int secondPlayerCard = player2[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    player1.Add(firstPlayerCard);
                    player1.Add(secondPlayerCard);

                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    player2.Add(firstPlayerCard);
                    player2.Add(secondPlayerCard);
                }


                player1.RemoveAt(0);
                player2.RemoveAt(0);

            }

            if (player1.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }

        }
    }
}
