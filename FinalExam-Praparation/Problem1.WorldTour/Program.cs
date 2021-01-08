using System;

namespace Problem1.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] token = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string manipulation = token[0];

                if (manipulation == "Add Stop")
                {
                    int index = int.Parse(token[1]);
                    string countryName = token[2];

                    if (index >= 0 && index <= input.Length)
                    {
                        input = input.Insert(index, countryName);

                    }

                }
                else if (manipulation == "Remove Stop")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);
                    int lenght = endIndex - startIndex;

                    //string substring = input.Substring(index, lenght);
                    //int indes1 = input.IndexOf(substring);
                    //input = input.Remove(indes1, substring.Length);

                    if (startIndex >= 0 && input.Length >= endIndex - 1 && endIndex >= 0)
                    {
                        string substring = input.Substring(startIndex, lenght);
                        input = input.Remove(startIndex, substring.Length + 1);
                    }
                }
                else if (manipulation == "Switch")
                {
                    string oldString = token[1];
                    string newString = token[2];

                    if (input.Contains(oldString))
                    {

                        input = input.Replace(oldString, newString);
                    }
                }
                Console.WriteLine(input);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
