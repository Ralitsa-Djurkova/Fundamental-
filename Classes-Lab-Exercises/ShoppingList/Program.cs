using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split("!").ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] elements = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string fisrtElement = elements[0];
                string secondElement = elements[1];

                switch (fisrtElement)
                {
                    case "Urgent":
                        if (!initialList.Contains(secondElement))
                        {
                            initialList.Insert(0,secondElement);
                        }
                        break;
                    case "Unnecessary":
                        if (initialList.Contains(secondElement))
                        {
                            initialList.Remove(secondElement);
                        }
                        break;
                    case "Correct":
                        if (initialList.Contains(secondElement))
                        {
                            string newElements = elements[2];
                            int index = initialList.IndexOf(secondElement);
                            

                            if (initialList.Contains(secondElement))
                            {
                                initialList.Insert(index, newElements);
                                initialList.Remove(secondElement);

                            }
                        }
                        break;
                    case "Rearrange":
                        if (initialList.Contains(secondElement))
                        {
                            initialList.Remove(secondElement);
                            initialList.Add(secondElement);
                        }
                        break;

                }

                command = Console.ReadLine();
            }
           
            Console.WriteLine(string.Join(", ",initialList));
        }
    }
}
