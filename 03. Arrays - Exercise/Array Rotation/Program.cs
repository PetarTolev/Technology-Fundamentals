using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            int num = 0;

            if (input.Length == n)
            {
                Console.WriteLine(string.Join(' ', input));
                return;
            }
            if (n < input.Length)
            {
                num = n;
            }
            else if (n > input.Length)
            {
                num = n - input.Length;
            }

            for (int i = num; i < input.Length; i++)
            {
                result.Add(input[i]);
            }
            for (int i = 0; i <= input.Length - result.Count; i++)
            {
                result.Add(input[i]);
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
