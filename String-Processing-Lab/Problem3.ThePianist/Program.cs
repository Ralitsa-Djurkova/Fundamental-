using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> info = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split("|");
                string piece = token[0];
                string compositor = token[1];
                string gama = token[2];

                if (!info.ContainsKey(piece))
                {
                    info.Add(piece, new List<string>() { "", "" });
                }
                info[piece][0] = compositor;
                info[piece][1] = gama;

            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] token = command.Split("|");
                string instruction = token[0];
                string piece = token[1];
                string compositor;
                string gama;
                if (instruction == "Add")
                {
                    compositor = token[2];
                    gama = token[3];

                    if (!info.ContainsKey(piece))
                    {

                        info.Add(piece, new List<string>() {"","" });
                        info[piece][0] = compositor;
                        info[piece][1] = gama;

                        Console.WriteLine($"{piece} by {compositor} in {gama} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (instruction == "Remove")
                {
                    if (info.ContainsKey(piece))
                    {
                        info.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (instruction == "ChangeKey")
                {
                    string newKey = token[2];
                    if (info.ContainsKey(piece))
                    {

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        info[piece][1] = newKey;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                command = Console.ReadLine();
            }



            foreach (var name in info.OrderBy(x => x.Key).ThenBy(x => x.Value[0])) 
            {
                Console.WriteLine($"{name.Key} -> Composer: {name.Value[0]}, Key: {name.Value[1]}");
            }


            
        }
    }
}
