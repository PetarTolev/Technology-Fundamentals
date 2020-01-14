using System;
using System.Globalization;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(GetDayOfWeek(input));
        }

        private static DayOfWeek GetDayOfWeek(string input)
        {
            string format = "d-M-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime day = DateTime.ParseExact(input, format, provider);

            return day.DayOfWeek;
        }
    }
}
