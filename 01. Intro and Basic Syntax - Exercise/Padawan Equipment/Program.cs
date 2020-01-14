using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            int freeBelts = countOfStudents / 6;

            priceOfLightsabers = priceOfLightsabers * (countOfStudents + Math.Ceiling(0.1 * countOfStudents));
            priceOfRobes = priceOfRobes * countOfStudents;
            priceOfBelts = priceOfBelts * (countOfStudents - freeBelts);

            double neededMoney = priceOfLightsabers + priceOfRobes + priceOfBelts;

            if (money >= neededMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(neededMoney - money):F2}lv more.");
            }
        }
    }
}