using System;

namespace Exchange_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:" +
                              $"{Environment.NewLine}a = {a}" +
                              $"{Environment.NewLine}b = {b}");
            Console.WriteLine($"After:" +
                              $"{Environment.NewLine}a = {b}" +
                              $"{Environment.NewLine}b = {a}");
        }
    }
}
