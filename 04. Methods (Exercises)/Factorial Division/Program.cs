using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            long firstFactorial = CalculateFactorial(n1);
            long secondFactorial = CalculateFactorial(n2);
            
            Console.WriteLine($"{(double)firstFactorial / secondFactorial:F2}");
        }

        private static long CalculateFactorial(int n)
        {
            long number = 1;
            for (long i = 2; i <= n; i++)
            {
                number *= i;
            }
            return number;
        }
    }
}
