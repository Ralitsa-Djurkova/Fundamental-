﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _06.Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split();

                string type = cmdArg[0].ToLower();
                string model = cmdArg[1];
                string color = cmdArg[2].ToLower();
                int hp = int.Parse(cmdArg[3]);

                Vehicle currentVeh = new Vehicle(type, model, color, hp);
                catalogue.Add(currentVeh);
                command = Console.ReadLine();


            }
            string secondCommand = Console.ReadLine();
            while (secondCommand != "Close the Catalogue")
            {
                string modelType = secondCommand;
                Vehicle printCar = catalogue.First(x => x.Model == modelType);

                Console.WriteLine(printCar);

                secondCommand = Console.ReadLine();
            }

            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTruck = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHp = onlyCars.Sum(x => x.HorsePower);
            double totalTrucksHp = onlyTruck.Sum(x => x.HorsePower);

            double avgCarHp = 0.00;
            double avgTruckHp = 0.00;

            if(onlyCars.Count > 0)
            {
                avgCarHp = totalCarsHp / onlyCars.Count;

            }
            if(onlyTruck.Count > 0)
            {
                avgTruckHp = totalTrucksHp / onlyTruck.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {avgCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");



        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
