using System;
using System.Xml;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                int n = 0;
                int backupI = i;
                while (backupI != 0)
                {
                    n += backupI % 10;
                    backupI /= 10;
                }
                string output = "";
                if (n == 5 || n == 7 || n == 11)
                {
                    output = "True";
                }
                else
                {
                    output = "False";
                }
                Console.WriteLine($"{i} -> {output}");
            }
        }
    }
}
