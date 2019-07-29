using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double discount = 1;
            double totalPrice = 0;
            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                totalPrice = price * people;

                if (people >= 30)
                {
                    totalPrice = totalPrice - (totalPrice * 0.15);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

                if (people >= 100)
                {
                    people -= 10;
                }
                totalPrice = price * people;
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }

                totalPrice = price * people;

                if (people >= 10 && people <= 20)

                {
                    totalPrice = totalPrice - (totalPrice * 0.05);
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
        }
    }
}
