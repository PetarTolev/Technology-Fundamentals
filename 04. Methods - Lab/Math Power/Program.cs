using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power));
        }

        private static double RaiseToPower(double n, int pow)
        {
            double result = n;

            for (int i = 1; i < pow; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}
