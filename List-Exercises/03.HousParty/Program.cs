using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HousParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] message = Console.ReadLine().Split();
                string guestName = message[0];
                if (message.Length > 3)
                {
                    if (guests.Contains(guestName))
                    {
                        guests.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(guestName))
                    {
                        guests.Add(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));

        }
    }
}
