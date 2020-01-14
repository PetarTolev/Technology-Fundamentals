namespace SoftUni_Parking
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            var ParkingData = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string licensePlateNumber = input[2];

                    if (ParkingData.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        ParkingData.Add(name, licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (ParkingData.ContainsKey(name))
                    {
                        ParkingData.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }

            foreach (var o in ParkingData)
            {
                Console.WriteLine($"{o.Key} => {o.Value}");
            }
        }
    }
}
