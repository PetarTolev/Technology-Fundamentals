using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(n1, n2, oper));
        }

        private static double Calculate(int n1, int n2, string o)
        {
            double result = 0d;
            switch (o)
            {
                case "/":
                    result = n1 / n2;
                    break;
                case "*":
                       result = n1 * n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }
            return result;
        }
    }
}
