using System;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMaxInt(n1, n2));
            }
            else if (type == "char")
            {
                char c1 = char.Parse(Console.ReadLine());
                char c2 = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMaxChar(c1, c2));
            }
            else
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

                Console.WriteLine(GetMaxString(s1, s2));
            }
        }

        private static string GetMaxString(string s1, string s2)
        {
            if (s1.CompareTo(s2) > 0)
            {
                return s1;
            }
            return s2;
        }

        private static char GetMaxChar(char c1, char c2)
        {
            char result;

            if (c1 > c2)
            {
                result = c1;
            }
            else
            {
                result = c2;
            }

            return result;
        }

        private static int GetMaxInt(int n1, int n2)
        {
            int result;

            if (n1 > n2)
            {
                result = n1;
            }
            else
            {
                result = n2;
            }

            return result;
        }
    }
}
