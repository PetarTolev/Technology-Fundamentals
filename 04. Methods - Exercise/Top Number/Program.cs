using System;

namespace Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 17)
            {
                return;
            }

            PrintTopNumber(n);
        }

        private static void PrintTopNumber(int n)
        {
            for (int i = 17; i < n; i++)
            {
                char[] array = i.ToString().ToCharArray();

                int sumNum = 0;

                foreach (var c in array)
                {
                    sumNum += (int) char.GetNumericValue(c);
                }
                
                if (DivisibleBy8(sumNum) && HoldOddDigit(array))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool HoldOddDigit(char[] numArray)
        {
            foreach (var c in numArray)
            {
                if ((int)char.GetNumericValue(c) % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool DivisibleBy8(int sumNum)
        {
            if (sumNum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
