using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] dayOfWeek = new string[7]{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Tuesday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"
            //};
            //int day = int.Parse(Console.ReadLine());
            //if (day >= 1 && day <= 7)
            //{
            //    Console.WriteLine(dayOfWeek[day - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");

            //}

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
