using System;
using System.Linq;

namespace From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new []{' '}).ToArray();
                long sum = 0;

                if (long.Parse(input[0]) > long.Parse(input[1]))
                {
                    long num = long.Parse(input[0]);
                    num = Math.Abs(num);
                    while (num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                }
                else
                {
                    long num = long.Parse(input[1]);
                    num = Math.Abs(num);
                    while (num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}
