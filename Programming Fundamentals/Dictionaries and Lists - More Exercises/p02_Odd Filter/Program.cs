    using System;
    using System.Linq;
    
    namespace p02_Odd_Filter
    {
        class Program
        {
            static void Main()
            {
                var items = Console.ReadLine().Split(' ').Select(int.Parse).ToList().Where(x => x % 2 == 0).ToList();
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] > items.Average() && items[i] % 2 == 0)
                    {
                        items.Add(items[i] + 1);
                        items.RemoveAt(0);
                    }
                    else if (items[i] <= items.Average() && items[i] % 2 == 0)
                    {
                        items.Add(items[i] - 1);
                        items.RemoveAt(0);
                    }
                    if (items[0] % 2 != 0)
                    {
                        break;
                    }
                    i--;
                }
                Console.WriteLine(string.Join(" ",items));
            }
        }
    }