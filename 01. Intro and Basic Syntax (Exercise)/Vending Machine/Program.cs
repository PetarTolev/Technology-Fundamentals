using System;
using System.Runtime.InteropServices;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var insert = Console.ReadLine();
            decimal sumOfCoins = 0.0m;
            while (insert != "Start")
            {
                decimal coin = decimal.Parse(insert);

                if (coin == 0.1m || coin == 0.2m || coin == 0.5m || coin == 1m || coin == 2m)
                {
                    sumOfCoins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                insert = Console.ReadLine();
            }

            var productName = Console.ReadLine();
            while (productName != "End")
            {
                decimal ProductPrice = 0;
                switch (productName)
                {
                    case "Nuts":
                        ProductPrice = 2.0m;
                        break;
                    case "Water":
                        ProductPrice = 0.7m;
                        break;
                    case "Crisps":
                        ProductPrice = 1.5m;
                        break;
                    case "Soda":
                        ProductPrice = 0.8m;
                        break;
                    case "Coke":
                        ProductPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (sumOfCoins >= ProductPrice && sumOfCoins > 0 && ProductPrice > 0)
                {
                    sumOfCoins -= ProductPrice;
                    Console.WriteLine($"Purchased {productName.ToLower()}");
                }
                else if (ProductPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                productName = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumOfCoins:F2}");
        }
    }
}
