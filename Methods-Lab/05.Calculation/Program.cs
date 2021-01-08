using System;
using System.ComponentModel;

namespace _05.Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            ClaculatatTotalPrice(command, num1);
            
        }

        static void ClaculatatTotalPrice(string command, int num)
        {
            double price = 0.0;
            if(command == "coffee")
            {
                 price = (double)num * 1.50;
            }
            else if(command == "water")
            {
                 price = (double)num * 1.00;
            }
            else if(command == "coke")
            {
                 price = (double)num * 1.40;
            }
            else if(command == "snacks")
            {
                 price = (double)num * 2.00;
            }
            Console.WriteLine($"{price:f2}");
            
        }

       
    }
}
