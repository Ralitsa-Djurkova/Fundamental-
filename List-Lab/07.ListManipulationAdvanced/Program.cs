using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;

                }

                string[] text = line.Split();

                switch (text[0])
                {
                    case "Contains":
                        int numbersToContains = int.Parse(text[1]);
                        numbers.Contains(numbersToContains);

                        if (numbers.Contains(numbersToContains))
                        {
                            Console.WriteLine("Yes");

                        }
                        else
                        {
                            Console.WriteLine("No such number");

                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int curNumToRemove = numbers[i];

                            if (curNumToRemove % 2 == 0)
                            {
                                List<int> evenNum = new List<int>();
                            }
                            else
                            {
                                numbers.Remove(curNumToRemove);
                            }
                            numbers.Add(curNumToRemove);

                        }
                        Console.WriteLine(string.Join(" ", numbers));

                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            int curNum = numbers[i];

                            if (i % 2 == 1)
                            {
                                List<int> oddNum = new List<int>();
                                numbers.Add(curNum);

                            }

                        }
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "GetSum":
                        break;
                }

                ;
            }
        }
    }
}
