using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace p04_Files
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var folders = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('\\');
                var root = input[0];
                var sizeAndExtension = input[input.Length - 1].Split(';');
                var fileName = sizeAndExtension[0];
                var fileSize = long.Parse(sizeAndExtension[1]);

                if (!folders.ContainsKey(root))
                {
                    folders[root] = new Dictionary<string, long>();
                }
                if (!folders[root].ContainsKey(fileName))
                {
                    folders[root].Add(fileName, fileSize);
                }
                else
                {
                    folders[root][fileName] = fileSize;
                }
            }
            var command = Console.ReadLine().Split(' ').ToList();
            var extension = command[0];
            var searchRoot = command[2];
            var finalFolders = folders.Where(x => x.Key == searchRoot).ToDictionary(x => x.Key, x => x.Value);

            var notEmpty = false;
            foreach (var folder in finalFolders)
            {
                foreach (var ext in folder.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (ext.Key.ToString().EndsWith(extension))
                    {
                        Console.WriteLine($"{ext.Key} - {ext.Value} KB");
                        notEmpty = true;
                    }
                }
            }
            if (!notEmpty)
            {
                Console.WriteLine("No");
            }
        }
    }
}