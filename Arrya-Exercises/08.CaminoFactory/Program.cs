using System;
using System.Linq;

namespace _08.CaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while(input != "Clone them!") 
            {
                int[] currentSequance = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                input = Console.ReadLine();
            }
            
        }
    }
}
