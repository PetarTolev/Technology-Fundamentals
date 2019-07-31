using System;
using System.Linq;
using System.Threading;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] secondInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[] result = new string[firstInput.Length];
            int count = 0;
            for (int i = 0; i < secondInput.Length; i++)
            {
                if (firstInput.Contains(secondInput[i]))
                {
                    result[count] = secondInput[i];
                    count++;
                }
            }
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
