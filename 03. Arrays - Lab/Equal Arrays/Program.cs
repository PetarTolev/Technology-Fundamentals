using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] input2 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool result = false;
            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == input2[i])
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine($"Arrays are identical. Sum: {input2.Sum()}");
            }
        }
    }
}
