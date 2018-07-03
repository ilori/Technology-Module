using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace p07_AndreyAndBilliard
{
    class Program
    {
        static void Main()
        {
            var shop = new Dictionary<string, decimal>();
            var productsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsCount; i++)
            {
                var input = Console.ReadLine().Split('-').ToList();
                var productName = input[0];
                var productPrice = decimal.Parse(input[1]);
                if (!shop.ContainsKey(productName))
                {
                    shop[productName] = 0;
                }
                shop[productName] = productPrice;
            }

            var inputLine = Console.ReadLine();
            var customers = new Dictionary<string, Customer>();
            while (inputLine != "end of clients")
            {
                var tokens = inputLine.Split('-', ',').ToList();
                var name = tokens[0];
                var product = tokens[1];
                var quantity = long.Parse(tokens[2]);
                if (shop.ContainsKey(product))
                {
                    var customer = new Customer();
                    customer.ShopList = new Dictionary<string, long>();
                    customer.Name = name;
                    customer.ShopList[product] = quantity;
                    if (!customers.ContainsKey(name))
                    {
                        customers[name] = customer;
                    }
                    else
                    {
                        if (!customers[name].ShopList.ContainsKey(product))
                        {
                            customers[name].ShopList[product] = quantity;
                        }
                        else
                        {
                            customers[name].ShopList[product] += quantity;
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }
            foreach (var customer in customers.OrderBy(x => x.Key))
            {
                Console.WriteLine(customer.Key);
                foreach (var item in customer.Value.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                    customer.Value.Bill += (shop[item.Key] * customers[customer.Key].ShopList[item.Key]);
                }
                Console.WriteLine($"Bill: {customer.Value.Bill:f2}");
            }
            Console.WriteLine($"Total bill: {customers.Values.Sum(x => x.Bill):f2}");
        }

        public class Customer
        {
            public decimal Bill { get; set; }
            public string Name { get; set; }
            public Dictionary<string, long> ShopList { get; set; }
        }
    }
}