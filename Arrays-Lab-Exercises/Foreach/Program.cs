using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };


            foreach(int currntNumber in numbers)
            {
                Console.WriteLine(currntNumber);
                
            }
        }
    }
}
