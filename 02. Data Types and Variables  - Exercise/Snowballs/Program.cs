using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 0;
            int resultSnowValue = 0;
            int resultTimeValue = 0;
            int resultQualityValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue >= result)
                {
                    result = snowballValue;

                    resultSnowValue = snowballSnow;
                    resultTimeValue = snowballTime;
                    resultQualityValue = snowballQuality;
                }
            }
            Console.WriteLine($"{resultSnowValue} : {resultTimeValue} = {result} ({resultQualityValue})");
        }
    }
}
