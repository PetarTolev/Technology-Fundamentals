using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            PrintCharInRange(c1, c2);
        }

        private static void PrintCharInRange(char c1, char c2)
        {
            if (c1 < c2)
            {
                for (int i = c1 + 1; i < c2; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = c2 + 1; i < c1; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
