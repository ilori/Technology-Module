using System;
using System.Collections.Generic;
using System.Linq;

namespace p01_Order_by_Age
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var customersList = new List<Customer>();
            while (input != "End")
            {
                var tokens = input.Split(' ').ToList();
                var name = tokens[0];
                var id = tokens[1];
                var age = int.Parse(tokens[2]);
                var customer = new Customer();
                customer.Age = age;
                customer.CustomerId = id;
                customer.Name = name;
                customersList.Add(customer);

                input = Console.ReadLine();
            }
            foreach (var customer in customersList.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{customer.Name} with ID: {customer.CustomerId} is {customer.Age} years old.");
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string CustomerId { get; set; }
        public int Age { get; set; }
    }
}