using System;
using System.Collections.Generic;
using System.Linq;

namespace p07_Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleInformation();
        }

        private static void SaleInformation()
        {
            int n = int.Parse(Console.ReadLine());
            var cityInformation = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var sale = new Sale(input[0], input[1], decimal.Parse(input[2]), decimal.Parse(input[3]));
                cityInformation.Add(sale);
            }
            var result = new SortedDictionary<string, decimal>();
            foreach (var sale in cityInformation)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }
                result[sale.Town] += sale.Price * sale.Quantity;
            }
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }
    }

    
}