using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double totalPrice = 0;
            double taxes = 0;
            double totalEndPrice = 0;
            double discountSpecial = 0;
            while (input != "special" || input != "regular")
            {
                if(input == "special")
                {
                    break;
                }
                if(input == "regular")
                {
                    break;
                }
                var price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPrice += price;
                    taxes = totalPrice * 0.2;
                    

                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                    }
                }

                input = Console.ReadLine();
            }

            if (input == "special")
            {
                totalEndPrice = totalPrice + taxes;
                discountSpecial = totalPrice * 0.1;
                

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalEndPrice - discountSpecial:f2}");

            }
            if (input == "regular")
            {

            }
        }
    }
}
