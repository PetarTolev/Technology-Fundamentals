using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> result = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] token = input.Split(' ');

                string serialNumber = token[0];
                string itemName = token[1];
                int itemQuantity = int.Parse(token[2]);
                decimal itemPrice = decimal.Parse(token[3]);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    Item = itemName,
                    Quantity = itemQuantity,
                    PriceBox = itemPrice
                };

                result.Add(box);

                input = Console.ReadLine();
            }

            result = result.OrderByDescending(o => o.PriceBox * o.Quantity).ToList();

            foreach (var box in result)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - {box.PriceBox:F2}: {box.Quantity}");
                Console.WriteLine($"-- {box.PriceBox * box.Quantity:F2}");
            }
        }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public string Item { get; set; }

        public int Quantity { get; set; }

        public decimal PriceBox { get; set; }
    }
}
