using System;
using System.Collections.Generic;

namespace Problem3.Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> plants = new Dictionary<string, Dictionary<string, double>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine().Split("<->");
                string namePlant = token[0];
                double rarity = double.Parse(token[1]);
                double rating = 0;

                if (plants.ContainsKey(namePlant))
                {
                    plants[namePlant][0] = rarity;
                }

                plants.Add(namePlant, new Dictionary<string, double>
                {
                    plants[namePlant]["rarity"][0] = rarity
                }) ;
            }
        }
    }
}
