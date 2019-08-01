using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetRectangleArea(width, height));
        }

        private static double GetRectangleArea(double w, double h)
        {
            double area = w * h;
            return area;
        }
    }
}
