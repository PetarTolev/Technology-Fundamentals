using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine(SignOfNumber(n));
        }

        public static string SignOfNumber(int num)
        {
            string result = "";
            if (num < 0)
            {
                result = $"The number {num} is negative.";
            }
            else if (num > 0)
            {
                result = $"The number {num} is positive.";
            }
            else
            {
                result = $"The number {num} is zero.";
            }
            return result;
        }
    }
}
