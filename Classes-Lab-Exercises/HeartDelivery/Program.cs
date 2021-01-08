using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighboorhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            int lastIndex = 0;

            while (command != "Love!")
            {
                string[] recievedCommand = command.Split();
                int index = 0;

                if (recievedCommand[0] == "Jump")
                {
                    index = int.Parse(recievedCommand[1]);
                }
                while (index > 0)
                {
                    lastIndex++;

                    if(lastIndex > neighboorhood.Length)
                    {
                        lastIndex = 0;
                        break; ;
                    }

                    index--;
                }
                if(neighboorhood[lastIndex] == 0)
                {
                    Console.WriteLine($"Place {lastIndex} already had Valentine's day.");
                }
                else
                {
                    neighboorhood[lastIndex] -= 2;

                    if (neighboorhood[lastIndex] == 0)
                    {
                        Console.WriteLine($"Place {lastIndex} has Valentine's day.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lastIndex}.");

            if(neighboorhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int houseCount = 0;

                for (int i = 0; i < neighboorhood.Length; i++)
                {
                    if(neighboorhood[i] != 0)
                    {
                        houseCount++;
                    }
                }
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }

        }
    }
}
