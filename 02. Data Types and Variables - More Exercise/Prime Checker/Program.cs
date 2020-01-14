using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool result = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {result.ToString().ToLower()}");
            }
        }
    }
}
