using System;
using System.Text;

namespace FinalExam04._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            while (command != "Generate")
            {
                string[] token = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string instruction = token[0];

                if (instruction == "Contains")
                {
                    string substring = token[1];
                    int index = input.IndexOf(substring);
                    
                    if (index != -1)
                    {
                        Console.WriteLine($"{command} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (instruction == "Flip")
                {
                    string latter = token[1];// upper|lower
                    int startIndex = int.Parse(token[2]);
                    int endIndex = int.Parse(token[3]);
                    int lenght = endIndex - startIndex;
                    if (latter == "Upper")
                    {
                        string oldString = input.Substring(startIndex, lenght);
                        string newString = input.Substring(startIndex, lenght).ToUpper();
                        input = input.Replace(oldString, newString);
                        Console.WriteLine(input);

                    }
                    else if (latter == "Lower")
                    {
                        string oldStirng = input.Substring(startIndex, lenght);
                        string newString = input.Substring(startIndex, lenght).ToLower();
                        input = input.Replace(oldStirng, newString);
                        Console.WriteLine(input);

                    }

                }
                else if(instruction == "Slice")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);
                    int lenght = endIndex - startIndex;
                    input = input.Remove(startIndex, lenght);
                    
                    Console.WriteLine(input);
                }
                command = Console.ReadLine();
            }
            sb.Append(input);
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
