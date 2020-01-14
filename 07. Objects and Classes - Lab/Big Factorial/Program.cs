using System;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetFactorial(n));
        }

        private static BigInteger GetFactorial(int n)
        {
            BigInteger num = 1;
            BigInteger factorial = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial = num * i;
                num = factorial;
            }

            return factorial;
        }
    }
}
