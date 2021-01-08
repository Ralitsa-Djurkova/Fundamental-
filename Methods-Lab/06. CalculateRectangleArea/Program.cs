using System;

namespace _06._CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetReactangleArea(width, height);
            Console.WriteLine(area); ;
        }

        static double GetReactangleArea(double width, double height)
        {
            double area = width * height;

            return(area);
        }
    }
}
