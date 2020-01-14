using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int sum = SumNumbers(n1, n2);
            Console.WriteLine(SubtractNumbers(sum, n3));
        }

        private static int SubtractNumbers(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }

        private static int SumNumbers(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
    }
}
