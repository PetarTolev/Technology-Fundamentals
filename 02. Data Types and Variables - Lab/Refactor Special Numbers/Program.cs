using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int n = 0;
            int backupNum;
            bool result;

            for (int i = 1; i <= num; i++)
            {
                backupNum = i;
                while (i > 0)
                {
                    n += i % 10;
                    i = i / 10;
                }

                result = (n == 5) || (n == 7) || (n == 11);
                Console.WriteLine($"{backupNum} -> {result}");
                n = 0;
                i = backupNum;
            }
        }
    }
}
