namespace Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;
    
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var c in input)
            {
                if (result.ContainsKey(c))
                {
                    result[c]++;
                }
                else
                {
                    result.Add(c, 1);
                }
            }

            if (result.ContainsKey(' '))
            {
                result.Remove(' ');
            }

            foreach (var i in result)
            {
                Console.WriteLine($"{i.Key} -> {i.Value}");
            }
        }
    }
}
