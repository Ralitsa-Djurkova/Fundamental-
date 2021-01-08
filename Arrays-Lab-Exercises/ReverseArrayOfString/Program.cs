using System;
using System.ComponentModel.Design;
using System.Linq;

namespace ReverseArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[text.Length - i - 1]+ " " );
            }
        }
    }
}
