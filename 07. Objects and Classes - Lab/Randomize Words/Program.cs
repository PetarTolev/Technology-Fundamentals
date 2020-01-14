using System;
using System.Xml;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(0, int.MaxValue); i++)
            {
                int n = rnd.Next(0, input.Length);

                string word = input[0];

                input[0] = input[n];

                input[n] = word; 
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
