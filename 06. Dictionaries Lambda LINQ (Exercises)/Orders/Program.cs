namespace Orders
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var products = new Dictionary<string, PriceAndQuantity>();

            while (input != "buy")
            {
                string[] product = input.Split(' ');
                string nameOfProduct = product[0];
                double priceOfProduct = double.Parse(product[1]);
                int quantityOfProduct = int.Parse(product[2]);

                if (products.ContainsKey(nameOfProduct))
                {
                    products[nameOfProduct].Quantity += quantityOfProduct;
                    products[nameOfProduct].Price = priceOfProduct;
                }
                else
                {
                    PriceAndQuantity priceAndQuantity = new PriceAndQuantity
                    {
                        Price = priceOfProduct,
                        Quantity = quantityOfProduct
                    };

                    products.Add(nameOfProduct, priceAndQuantity);
                }
                
                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value.Price * product.Value.Quantity;

                Console.WriteLine($"{product.Key} -> {totalPrice:F2}");
            }
        }

        class PriceAndQuantity
        {
            public double Price { get; set; }

            public int Quantity { get; set; }
        }
    }
}
