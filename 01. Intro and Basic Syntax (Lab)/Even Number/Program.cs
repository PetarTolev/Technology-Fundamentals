using System;

namespace Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");

                num = int.Parse(Console.ReadLine());
            }
            if (num < 0)
            {
                Console.WriteLine($"The number is: {num * -1}");
            }
            else
            {
                Console.WriteLine($"The number is: {num}");
            }
        }
    }
}
