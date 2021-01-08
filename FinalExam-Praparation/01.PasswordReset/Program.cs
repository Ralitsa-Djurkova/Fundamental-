using System;
using System.Text;

namespace _01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();


            while (command != "Done")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string instruction = cmdArg[0];
                if (instruction == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i % 2 == 1)
                        {
                            char currCh = input[i];
                            sb.Append(currCh);
                        }

                    }
                    input = sb.ToString();
                    Console.WriteLine(input);
                }
                else if (instruction == "Cut")
                {
                    int index = int.Parse(cmdArg[1]);
                    int lenght = int.Parse(cmdArg[2]);
                    int test = index + lenght;
                    if (test <= input.Length)
                    {
                        string substring = input.Substring(index, lenght);
                        int indes1 = input.IndexOf(substring);
                        input = input.Remove(indes1, substring.Length);
                        Console.WriteLine(input);
                    }

                }
                else if (instruction == "Substitute")
                {
                    string firstCh = cmdArg[1];
                    string secomdCh = cmdArg[2];

                    if (input.Contains(firstCh))
                    {
                        input = input.Replace(firstCh, secomdCh);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }




                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
