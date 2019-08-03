namespace Word_Filter
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, word));
        }
    }
}
