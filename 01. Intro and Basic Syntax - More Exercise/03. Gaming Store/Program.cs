using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double totalSpent = 0;

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
                    break;
                }

                double gamePrice;

                switch (inputLine)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }

                if (currentBalance - gamePrice < 0)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= gamePrice;
                    totalSpent += gamePrice;

                    Console.WriteLine($"Bought {inputLine}");
                }

                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
        }
    }
}
