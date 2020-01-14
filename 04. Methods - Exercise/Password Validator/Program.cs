using System;
using System.Linq;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool checkIsBetween6And10Symbol = IsBetween6And10Symbol(input);
            if (checkIsBetween6And10Symbol)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool checkContainsOnlyDigitsAndLetters = ContainsOnlyDigitsAndLetters(input);
            if (checkContainsOnlyDigitsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool checkContainsTwoDigits = ContainsTwoDigits(input);
            if (checkContainsTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (!checkContainsOnlyDigitsAndLetters && !checkIsBetween6And10Symbol && !checkContainsTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ContainsTwoDigits(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char symbol = s[i];

                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return false;
            }

            return true;
        }

        private static bool ContainsOnlyDigitsAndLetters(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char symbol = s[i];

                bool letter = char.IsLetter(symbol);
                bool digit = char.IsDigit(symbol);

                if (!letter && !digit)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsBetween6And10Symbol(string s)
        {
            if (s.Length < 6 || s.Length > 10)
            {
                return true;
            }

            return false;
        }
    }
}
