using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            while (num != "END")
            {
                char[] numInArray = num.ToCharArray();

                Console.WriteLine(CheckNumber(numInArray).ToString().ToLower());

                num = Console.ReadLine();
            }
        }

        private static bool CheckNumber(char[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                bool isSame = array[i] == array[array.Length - i - 1];
                if (!isSame)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
