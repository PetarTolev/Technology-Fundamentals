using System;

namespace Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int initialHealth = 100;
            int initialCoins = 0;

            bool isDead = true;

            for (int i = 0; i < input.Length; i++)
            {
                string[] arr = input[i].Split(' ');

                string itemOrMonster = arr[0];
                int n = int.Parse(arr[1]);

                if (itemOrMonster == "potion")
                {
                    if (initialHealth + n <= 100)
                    {
                        initialHealth += n;
                        Console.WriteLine($"You healed for {n} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                        initialHealth = 100;
                        Console.WriteLine($"Current health: 100 hp.");
                    }
                }
                else if (itemOrMonster == "chest")
                {
                    initialCoins += n;
                    Console.WriteLine($"You found {n} coins.");
                }
                else
                {
                    initialHealth -= n;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {itemOrMonster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {itemOrMonster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        isDead = false;
                        break;
                    }
                }
            }
            if (isDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Coins: {initialCoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
