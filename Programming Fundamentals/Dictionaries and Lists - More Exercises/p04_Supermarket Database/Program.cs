using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Supermarket_Database
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var productQuantity = new Dictionary<string, int>();
            var productsPrice = new Dictionary<string, decimal>();

            ;

            while (input[0] != "stocked")
            {
                var productName = input[0];
                var productPrice = decimal.Parse(input[1]);
                var quantity = int.Parse(input[2]);

                if (!productQuantity.ContainsKey(productName))
                {
                    productQuantity[productName] = quantity;
                    productsPrice[productName] = productPrice;
                }
                else
                {
                    productQuantity[productName] += quantity;
                    productsPrice[productName] = productPrice;
                }

                input = Console.ReadLine().Split(' ').ToList();
            }
            var totalMoney = 0m;
            foreach (var product in productsPrice)
            {
                Console.WriteLine(
                    $"{product.Key}: ${product.Value} * {productQuantity[product.Key]} = ${product.Value * productQuantity[product.Key]}");

                totalMoney += product.Value * productQuantity[product.Key];
            }
            Console.WriteLine($"------------------------------");
            Console.WriteLine($"Grand Total: ${totalMoney:f2}");
        }
    }
}