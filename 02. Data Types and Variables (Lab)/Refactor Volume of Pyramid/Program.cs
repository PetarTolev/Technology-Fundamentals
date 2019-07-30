using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            
            double volumeOfPiramid = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volumeOfPiramid); 
        }
    }
}
