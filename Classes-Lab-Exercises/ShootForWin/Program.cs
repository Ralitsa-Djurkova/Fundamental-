using System;
using System.Linq;

namespace ShootForWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            int index = -1;
            int counter = 0;
            while (input != "End")
            {
                int currIndex = int.Parse(input);
                if (currIndex < targets.Length && currIndex >= 0)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int temp = targets[currIndex];
                        if (targets[i] != -1 && i != currIndex)
                        {
                            if (targets[i] > temp)
                            {
                                targets[i] -= temp;
                            }
                            else if (targets[i] <= temp)
                            {
                                targets[i] += temp;
                            }
                        }
                    }

                    targets[currIndex] = -1;
                    counter++;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> "+ string.Join(' ', targets));
        }
    }
}
