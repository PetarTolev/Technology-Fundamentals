using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            long result = 0;

            while (num != 0)
            {
                result += num % 10;
                num /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
