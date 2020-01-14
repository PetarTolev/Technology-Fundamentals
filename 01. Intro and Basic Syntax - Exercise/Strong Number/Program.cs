using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = Console.ReadLine();
            int sumForEnd = int.Parse(sum);
            var sumFactoriel = 0;
            while (sum.Length != 0)
            {
                int num = (int) char.GetNumericValue(sum[sum.Length - 1]);
                sum = sum.Remove(sum.Length - 1);

                var factoriel = 1;

                for (int i = 1; i <= num; i++)
                {
                    factoriel *= i;
                }
                sumFactoriel += factoriel;
            }

            if (sumFactoriel == sumForEnd)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
