using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] splittedInput = input.Split(' ');

                string type = splittedInput[0].ToLower();
                string model = splittedInput[1];
                string color = splittedInput[2];
                int hp = int.Parse(splittedInput[3]);

                Vehicle vehicle = new Vehicle()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HP = hp
                };

                vehicles.Add(vehicle);

                input = Console.ReadLine();
            }

            string commandModel = Console.ReadLine();

            while (commandModel != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (vehicle.Model == commandModel)
                    {
                        string type = vehicle.Type;
                        string model = vehicle.Model;
                        string color = vehicle.Color;
                        int hp = vehicle.HP;

                        type = FirstCharToUpper(type);

                        Console.WriteLine($"Type: {type}");
                        Console.WriteLine($"Model: {model}");
                        Console.WriteLine($"Color: {color}");
                        Console.WriteLine($"Horsepower: {hp}");
                    }
                }

                commandModel = Console.ReadLine();
            }
            
            if (vehicles.Where(x => x.Type == "car").Count() > 0)
            {
                double averageHpCars = vehicles.Where(x => x.Type == "car").Select(x => x.HP).Average();
                Console.WriteLine($"Cars have average horsepower of: {averageHpCars:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (vehicles.Where(x => x.Type == "truck").Count() > 0)
            {
                double averageHpTruck = vehicles.Where(x => x.Type == "truck").Select(x => x.HP).Average();
                Console.WriteLine($"Trucks have average horsepower of: {averageHpTruck:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }

        private static string FirstCharToUpper(string word)
        {
            return word.First().ToString().ToUpper() + word.Substring(1);
        }
    }

    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HP { get; set; }
    }
}
