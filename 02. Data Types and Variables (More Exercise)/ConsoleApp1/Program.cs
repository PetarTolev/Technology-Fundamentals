using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                long value;
                char charValue;
                float doubleValue;

                if (long.TryParse(input, out value))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out doubleValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (input == "true" || input == "false")
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");                    
                }

                input = Console.ReadLine();
            }
        }
    }
}
