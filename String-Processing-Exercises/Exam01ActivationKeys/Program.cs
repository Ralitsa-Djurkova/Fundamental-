using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam01ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] cmdArg = command.Split(">>>");
                string instruction = cmdArg[0];
                if (instruction == "Contains")
                {
                    string substring = cmdArg[1];
                    bool isContains = input.Contains(substring);
                    if (isContains)
                    {
                        Console.WriteLine($"{input} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (instruction == "Flip")
                {
                    string upperLatter = cmdArg[1];
                    int startIndex = int.Parse(cmdArg[2]);
                    int endIndex = int.Parse(cmdArg[3]);
                    if (upperLatter == "Upper")
                    {
                        if (startIndex >= 0 && startIndex <= input.Length - 1
                            && endIndex >= 0 && endIndex <= input.Length - 1)
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char currentSymbol = char.Parse(input[i].ToString().ToUpper());
                                input = input.Replace(input[i], currentSymbol);
                            }
                        }
                        Console.WriteLine(input);

                    }
                    else if (upperLatter == "Lower")
                    {
                        if (startIndex >= 0 && startIndex <= input.Length - 1
                           && endIndex >= 0 && endIndex <= input.Length - 1)
                        {
                            for (int i = startIndex; i < endIndex; i++)
                            {
                                char currentSymbol = char.Parse(input[i].ToString().ToLower());
                                input = input.Replace(input[i], currentSymbol);
                            }
                        }
                        Console.WriteLine(input);
                    }


                }
                else if (instruction == "Slice")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        input = input.Remove(startIndex, 1);
                    }
                    Console.WriteLine(input);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
