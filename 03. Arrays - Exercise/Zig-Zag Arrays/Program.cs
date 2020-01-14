using System;
using System.Collections.Generic;
using System.Linq;

namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 1)
                {
                    result1.Add(input[0]);
                    result2.Add(input[1]);
                }
                else
                {
                    result1.Add(input[1]);
                    result2.Add(input[0]);
                }
            }
            Console.WriteLine(string.Join(' ', result1));
            Console.WriteLine(string.Join(' ', result2));
        }
    }
}
