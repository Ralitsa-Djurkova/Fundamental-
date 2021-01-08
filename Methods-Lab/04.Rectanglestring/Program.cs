﻿using System;
using System.Text;

namespace _04.Rectanglestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            PrintString(text, num);
        }

        static void PrintString(string str, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }

            Console.WriteLine(result.ToString());
        }
    }
}
