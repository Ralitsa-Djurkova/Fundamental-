using System;
using System.Collections.Generic;
using System.Linq;



namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] element = command.Split();
                if (element[0] == "Delete")
                {

                    int elementDel = int.Parse(element[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == elementDel)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }

                }
                if (element[0] == "Insert")
                {
                    int numbersInsert = int.Parse(element[1]);
                    int indexInsert = int.Parse(element[2]);
                    numbers.Insert(indexInsert, numbersInsert);

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
