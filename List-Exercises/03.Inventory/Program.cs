using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .ToList();

            
            string input = Console.ReadLine(); 
            while (input != "Craft!")
            {
                string[] cmArgs = input.Split('-').ToArray();
                string command = cmArgs[0];
                string index = cmArgs[1];
               
                if (command == "Collect")
                {
                    if (!items.Contains(index))
                    {
                        items.Add(index);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (command == "Drop")
                {
                    if (items.Contains(index))
                    {
                        int currIndex = int.Parse(cmArgs[1]);
                        items.RemoveAt(currIndex);
                    }
                }
                else if (command == "Combine Items ")
                {
                    string newElement = cmArgs[2];
                    if (!items.Contains(index))
                    {
                        items.Add(index);
                    }
                    else if (!items.Contains(newElement))
                    {
                        items.Add(newElement);
                    }
                }
                else if (command == "Renew")
                {
                    if (items.Contains(index))
                    {
                        int curIndex = int.Parse(cmArgs[1]);
                        items.RemoveAt(curIndex);
                        string seconPosition = cmArgs[2];

                        int indexFirst = items.IndexOf(index);
                        int indexSecond = items.IndexOf(seconPosition);

                        if (indexFirst != -1 && indexSecond != -1)
                        {
                            items[indexFirst] = seconPosition;
                            items[indexSecond] = index;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
