using System;
using System.IO;

namespace Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] months =
            {
                "January", "February", "March", "April", "May", "Juny",
                "July", "August", "September", "October", "November", "December"
            };
            if (day > 0 && day < 13 )
            {
                Console.WriteLine(months[day - 1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
