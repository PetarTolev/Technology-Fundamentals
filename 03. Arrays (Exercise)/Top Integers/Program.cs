using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i == input.Count - 1)
                {
                    result.Add(input[i]);
                    Console.WriteLine(string.Join(' ', result));
                    return;
                }
                if (input[i] > input[i + 1])
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
