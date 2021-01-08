using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').ToList();

            numbers.Reverse();
            List<string> list = new List<string>();


            foreach (string currentItem in numbers)
            {
                string[] number = currentItem.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach  (string numberToAdd in number)
                {
                    list.Add(numberToAdd);
                }
            }

            Console.WriteLine(string.Join(' ', list));
           

        }
    }
}
