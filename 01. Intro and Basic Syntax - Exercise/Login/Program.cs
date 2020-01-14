using System;
using System.Linq;
using System.Threading;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();

            var reverse = "";
            for (int i = user.Length - 1; i >= 0; i--)
            {
                reverse += user[i];
            }
            
            string password = Console.ReadLine();
            int count = 1;

            while (password != reverse)
            {
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                count++;
                if (count > 3)
                {
                    break;
                }
            }
            if (count < 4)
            {
                Console.WriteLine($"User {user} logged in.");
            }
            else
            {
                Console.WriteLine($"User {user} blocked!");
            }
        }
    }
}
