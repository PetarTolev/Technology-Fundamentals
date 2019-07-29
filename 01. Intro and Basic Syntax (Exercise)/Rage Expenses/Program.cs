using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetBroken = 0;
            int mouseBroken = 0;
            int keyboardBroken = 0;
            int displayBroken = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetBroken++;
                }
                if (i % 3 == 0)
                {
                    mouseBroken++;
                }
                if (i % 6 == 0)
                {
                    keyboardBroken++;
                }
                if (i % 12 == 0)
                {
                    displayBroken++;
                }
            }

            headsetPrice = headsetBroken * headsetPrice;
            mousePrice = mouseBroken * mousePrice;
            keyboardPrice = keyboardBroken * keyboardPrice;
            displayPrice = displayBroken * displayPrice;
            double generalPrice = headsetPrice + mousePrice + keyboardPrice + displayPrice;

            Console.WriteLine($"Rage expenses: {generalPrice:F2} lv.");
        }
    }
}
