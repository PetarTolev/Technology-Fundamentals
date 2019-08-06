using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split('/');

                Car car = new Car();
                Truck truck = new Truck();

                string type = tokens[0];

                if (type == "Car")
                {
                    GetInfoForCars(tokens, car, cars);
                }
                else if (type == "Truck")
                {
                    GetInfoForTruck(tokens,truck, trucks);
                }

                input = Console.ReadLine();
            }

            PrintCars(cars);

            PrintTRucks(trucks);
        }

        private static void PrintTRucks(List<Truck> trucks)
        {
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                trucks = trucks.OrderBy(a => a.Brand).ToList();

                foreach (Truck truck in trucks)
                {
                    string brand = truck.Brand;
                    string model = truck.Model;
                    int weight = truck.Weight;

                    Console.WriteLine($"{brand}: {model} - {weight}kg");
                }
            }
        }

        private static void PrintCars(List<Car> cars)
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                cars = cars.OrderBy(a => a.Brand).ToList();

                foreach (Car car in cars)
                {
                    string brand = car.Brand;
                    string model = car.Model;
                    int HP = car.HP;

                    Console.WriteLine($"{brand}: {model} - {HP}hp");
                }
            }
        }

        private static void GetInfoForCars(string[] tokens, Car car, List<Car> cars)
        {

            string brand = tokens[1];
            string model = tokens[2];
            int hp = int.Parse(tokens[3]);

            car.Brand = brand;
            car.Model = model;
            car.HP = hp;

            cars.Add(car);
        }

        public static void GetInfoForTruck(string[] tokens, Truck truck, List<Truck> trucks)
        {
            string brand = tokens[1];
            string model = tokens[2];
            int weight = int.Parse(tokens[3]);

            truck.Brand = brand;
            truck.Model = model;
            truck.Weight = weight;

            trucks.Add(truck);
        }
    }


    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HP { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
}