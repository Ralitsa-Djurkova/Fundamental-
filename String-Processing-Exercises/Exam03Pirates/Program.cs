using System;
using System.Collections.Generic;

namespace Exam03Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> collection = new Dictionary<string, List<int>>();

            int totalGold = 0;
            while (command != "Sail")
            {
                string[] cmdArg = command.Split("||");
                string city = cmdArg[0];
                int population = int.Parse(cmdArg[1]);
                int gold = int.Parse(cmdArg[2]);

                if (!collection.ContainsKey(city))
                {
                    collection.Add(city, new List<int>());

                }

                collection[city] += gold;
                collection[city].Add(population);
                command = Console.ReadLine();
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArg = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string inastrution = cmdArg[0];
                if (inastrution == "Plunder")
                {
                    string city = cmdArg[1];
                    int population = int.Parse(cmdArg[2]);
                    int gold = int.Parse(cmdArg[3]);

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {population} citizens killed.");

                    if (population <= 0 || gold <= 0)
                    {
                        collection.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }
                }
                else if (inastrution == "Prosper")
                {
                    string town = cmdArg[1];

                    int gold = int.Parse(cmdArg[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {

                        if (collection.ContainsKey(town))
                        {
                            totalGold += gold;
                            collection[town].Add(totalGold);
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {totalGold} gold.");
                        }
                    }
                }

                input = Console.ReadLine();
            }

           
        }
    }
}
