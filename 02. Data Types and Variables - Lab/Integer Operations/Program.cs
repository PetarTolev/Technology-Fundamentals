using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int sum = a + b;
            int divide = sum / c;
            int multiply = divide * d;

            Console.WriteLine(multiply);
        }
    }
}
