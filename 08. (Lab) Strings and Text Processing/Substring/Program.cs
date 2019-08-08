using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine().ToLower();

            while (secondString.Contains(firstString))
            {
                int index = secondString.IndexOf(firstString);
                int length = firstString.Length;

                secondString = secondString.Remove(index, length);
            }
            Console.WriteLine(secondString);
        }
    }
}
