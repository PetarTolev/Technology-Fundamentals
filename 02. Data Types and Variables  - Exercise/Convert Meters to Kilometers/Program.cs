using System;

namespace Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double km = meters / 1000;
            Console.WriteLine($"{km:F2}");
        }
    }
}
