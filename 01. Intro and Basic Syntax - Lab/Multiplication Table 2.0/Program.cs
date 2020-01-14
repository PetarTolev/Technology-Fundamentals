using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            if (endNum > 10)
            {
                Console.WriteLine($"{num} X {endNum} = {num * endNum}");
            }
            else
            {
                for (int i = endNum; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {num * i}");
                }
            }

        }
    }
}
