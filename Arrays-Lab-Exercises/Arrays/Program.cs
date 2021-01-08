using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7] {

                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };
            Console.WriteLine("Enter what you wont (1-7)");
            int dayAsNumber = int.Parse(Console.ReadLine());
            if(dayAsNumber < 1|| dayAsNumber > 7)
            {
                Console.WriteLine("Zasto?");
                Console.WriteLine("Posleden Shans!!!");
                dayAsNumber = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("The day is: " + daysOfWeek[dayAsNumber - 1]);
            
        }
    }
}
