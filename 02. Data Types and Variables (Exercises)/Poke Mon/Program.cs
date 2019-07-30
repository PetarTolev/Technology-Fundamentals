using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            int count = 0;
            int originalValueOfN = N;
            while (N >= M)
            {
                if (N == originalValueOfN / 2 && Y != 0)
                {
                    N /= Y;
                    if (N < M)
                    {
                        break;
                    }
                }
                N -= M;
                count++;
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
