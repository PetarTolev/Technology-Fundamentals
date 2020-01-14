using System;
using System.Linq;
using System.Net.Mail;

namespace Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions
                .RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum =0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenSum += input[i];
                }
                else
                {
                    oddSum += input[i];
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
