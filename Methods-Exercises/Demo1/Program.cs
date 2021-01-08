using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection.PortableExecutable;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
        }

        static void PrintMiddleOdd(string text)
        {
            int current = text.Length / 2;
            string cur = text.Substring(current, 1);
           
        }
        static void PrintMiddleEven(string text)
        {
            int current = text.Length / 2;
            string cur = text.Substring(current - 1, 2);
        }
       
    }
}
