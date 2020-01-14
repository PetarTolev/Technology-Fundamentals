using System;
using System.Dynamic;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            GetVowelsInString(input);
        }

        private static void GetVowelsInString(string s)
        {
            char[] asd = s.ToCharArray();

            int result = 0;

            foreach (char c in asd)
            {
                if (c == 'a' || c == 'o' || c == 'i' || c == 'u' || c == 'e')
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
