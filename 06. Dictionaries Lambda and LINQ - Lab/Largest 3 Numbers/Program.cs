using System;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            Console.WriteLine(string.Join(' ',sorted.Take(3)));
        }
    }
}
