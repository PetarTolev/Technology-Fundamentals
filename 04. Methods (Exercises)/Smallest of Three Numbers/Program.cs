using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            GetSmallesOfThreeNums(n1, n2, n3);
        }

        private static void GetSmallesOfThreeNums(int n1, int n2, int n3)
        {
            int result = 0;

            if (n1 <= n2)
            {
                if (n1 < n3)
                {
                    Console.WriteLine(n1);
                }
                else
                {
                    Console.WriteLine(n3);
                }
            }
            else if (n2 <= n1)
            {
                if (n2 < n3)
                {
                    Console.WriteLine(n2);
                }
                else
                {
                    Console.WriteLine(n3);
                }
            }
        }
    }
}
