using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintingMiddleCharacters(input);
        }

        private static void PrintingMiddleCharacters(string s)
        {
            if (s.Length % 2 == 0)
            {
                Console.Write(s[s.Length / 2 - 1]);
                Console.WriteLine(s[s.Length / 2]);
            }
            else
            {
                Console.WriteLine(s[s.Length / 2]);
            }
        }
    }
}
