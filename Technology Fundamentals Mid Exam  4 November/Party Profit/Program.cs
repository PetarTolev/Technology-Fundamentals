using System;
using Microsoft.Win32.SafeHandles;

namespace Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 50 * days;

            for (int i = 1; i <= days; i++)
            {

                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                coins -= 2 * partySize;

                if (i % 3 == 0)
                {
                    coins -= 3 * partySize;
                }

                if (i % 5 == 0)
                {
                    coins += 20 * partySize;
                }

                if (i % 5 == 0 && i % 3 == 0)
                {
                    coins -= 2 * partySize;
                }
            }

            int result = coins / partySize;

            Console.WriteLine($"{partySize} companions received {result} coins each.");
        }
    }
}
