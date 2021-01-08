using System;
using System.Collections.Generic;

namespace Problem3.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> musicants = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string compositor = input[1];
                string key = input[2];

                musicants.Add(piece, new List<string>());
                musicants[piece].Add(compositor);
                musicants[piece].Add(key);
            }
        }
    }
}
