using System;
using System.Collections.Generic;
using System.Linq;

namespace LIstsExercises15._10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "end")
                {
                    break;
                }

                string[] line = command.Split();

                if (line[0] == "Add")
                {
                    int passengerAdd = int.Parse(line[1]);
                    wagon.Add(passengerAdd);
                }
                else
                {
                    int passengers = int.Parse(line[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {

                        if (wagon[i] + passengers <= maxCacity)
                        {
                            wagon[i] += passengers;
                            break;
                        }
                    }

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagon));
        }
    }
}
