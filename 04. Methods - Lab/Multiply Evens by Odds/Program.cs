using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        private static int GetMultipleOfEvenAndOdds(int n)
        {
            int sumOfEven = 0;
            int sumOfOdd = 0;

            while (n != 0)
            {
                int num = n % 10;
                n = n / 10;

                if (num % 2 == 0)
                {
                    sumOfEven += GetSumOfEvenDigits(num);
                }
                else
                {
                    sumOfOdd += GetSumOfOddDigits(num);
                }
            }
            int result = sumOfOdd * sumOfEven;
            return result;
        }

        private static int GetSumOfOddDigits(int n)
        {
            List<int> sum = new List<int>();
            sum.Add(n);
            return sum.Sum();
        }

        private static int GetSumOfEvenDigits(int n)
        {
            List<int> sum = new List<int>();
            sum.Add(n);
            return sum.Sum();
        }
    }
}
