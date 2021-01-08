using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();
            Dictionary<string, int> timesRated = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split("<->");
                string plantsName = information[0];
                double rarity = double.Parse(information[1]);
                double rating = 0;
                if (!plants.ContainsKey(plantsName))
                {
                    plants.Add(plantsName, new List<double>() {rarity, 0});
                  
                }
                else
                {
                    plants[plantsName][0] = rarity;
                }
            }
            string command = Console.ReadLine();


            while (command != "Exhibition")
            {
                char[] separator = new char[] { ':', '-', ' ' };
                string[] input = command.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                string instruction = input[0];
                string plantsName = input[1];

                if (!plants.ContainsKey(plantsName))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    if (instruction == "Rate")
                    {
                        double rating = double.Parse(input[2]);
                        plants[plantsName][1] += rating;

                        if (!timesRated.ContainsKey(plantsName))
                        {
                            timesRated.Add(plantsName, 1);
                        }
                        else
                        {
                            timesRated[plantsName]++;
                        }
                    }
                    else if (instruction == "Update")
                    {
                        int newRarity = int.Parse(input[2]);
                        plants[plantsName][0] = newRarity;

                    }
                    else if (instruction == "Reset")
                    {
                        plants[plantsName].RemoveRange(1, plants[plantsName].Count - 1);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                command = Console.ReadLine();
            }


            foreach (var item in plants.ToDictionary(x => x.Key, x =>x.Value))
            {
                if (timesRated.ContainsKey(item.Key))
                {
                    plants[item.Key][1] = item.Value[1] / timesRated[item.Key];
                }
            }
            Console.WriteLine($"Plants for the exhibition:");

            foreach (var item in plants.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]}");
            }
        }
    }
}
