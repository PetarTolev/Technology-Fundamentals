using System;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine($"{area:F12}");
        }
    }
}
