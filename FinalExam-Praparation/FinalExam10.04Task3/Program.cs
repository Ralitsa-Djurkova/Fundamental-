using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalExam10._04Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cars = new Dictionary<string, Dictionary<string, int>>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string nameCar = input[0];
                int mileageCar = int.Parse(input[1]);
                int fuelCar = int.Parse(input[2]);

                cars.Add(nameCar, new Dictionary<string, int>()
                {
                    {"mileage", mileageCar },
                    {"fuel", fuelCar }
                });

            }
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] token = command.Split(" : ");
                string instruction = token[0];
                string carName = token[1];
                if (instruction == "Drive")
                {
                    int distance = int.Parse(token[2]);
                    int fuel = int.Parse(token[3]);

                    var carFuel = cars[carName]["fuel"];

                    if (fuel > carFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carName]["mileage"] += distance;
                        cars[carName]["fuel"] -= fuel;
                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    }
                    if (cars[carName]["mileage"] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {carName}!");
                        cars.Remove(carName);
                    }

                }
                else if (instruction == "Refuel")
                {
                    int fuel = int.Parse(token[2]);
                    int maxFuel = 75;

                    var carFuel = cars[carName]["fuel"];

                    if (carFuel + fuel > maxFuel)
                    {
                        fuel = 75 - carFuel;
                    }
                    cars[carName]["fuel"] += fuel;
                    Console.WriteLine($"{carName} refueled with {fuel} liters");
                }
                else if (instruction == "Revert")
                {
                    int kilometers = int.Parse(token[2]);

                    cars[carName]["mileage"] -= kilometers;

                    if (cars[carName]["mileage"] < 10000)
                    {
                        cars[carName]["mileage"] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }
                command = Console.ReadLine();
            }

            var order = cars.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key);

            foreach (var car in order)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]} kms, Fuel in the tank: {car.Value["fuel"]} lt.");
            }
        }
    }
}
