using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = Console.ReadLine();
            int countShoot = 0;

            while (command != "End")
            {
                string[] cmdArg = command.Split(" ");
                string firstElement = cmdArg[0];
                int index = int.Parse(cmdArg[1]);
                int power = int.Parse(cmdArg[2]);

                if(firstElement == "Shoot")
                {
                    if (index >= 0 && index < target.Count)
                    {
                        target[index] -= power;

                        if(target[index] <= 0)
                        {
                            countShoot++;
                            target.RemoveAt(index);
                        }
                    }
                }
                else if(firstElement == "Add")
                {
                    if (index >= 0 && index < cmdArg.Length)
                    {
                        target.Insert(index, power);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if(firstElement == "Strike")
                {
                    if (index - power >= 0 && index + power < target[target.Count - 1])
                    {
                        
                        target.RemoveRange(index - power, power * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|",target));
        }
    }
}
