using System;
using System.Runtime.InteropServices;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price = 0.00;

            if (product == "coffee" )
            {
                price = 1.50;
                CalculatePrice(quantity, price);
            }
            else if (product == "coke")
            {
                price = 1.40;
                CalculatePrice(quantity, price);
            }
            else if (product == "water")
            {
                price = 1.00;
                CalculatePrice(quantity, price);
            }
            else if (product == "snacks")
            {
                price = 2.00;
                CalculatePrice(quantity, price);
            }
        }

        private static void CalculatePrice (int quantity, double price)
        {
            double totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
