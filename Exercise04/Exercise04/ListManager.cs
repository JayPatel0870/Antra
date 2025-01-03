using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class ListManager
    {
        public void todo()
        {
            List<string> itemList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
                string input = Console.ReadLine()?.Trim(); 

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid command. Please try again.");
                    continue;
                }

                if (input == "--")
                {
                    itemList.Clear();
                    Console.WriteLine("List cleared.");
                }
                else if (input.StartsWith("+"))
                {
                    string itemToAdd = input.Substring(1).Trim();
                    if (!string.IsNullOrEmpty(itemToAdd))
                    {
                        itemList.Add(itemToAdd);
                        Console.WriteLine($"Added: {itemToAdd}");
                    }
                    else
                    {
                        Console.WriteLine("No item specified to add.");
                    }
                }
                else if (input.StartsWith("-"))
                {
                    string itemToRemove = input.Substring(1).Trim();
                    if (itemList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Removed: {itemToRemove}");
                    }
                    else
                    {
                        Console.WriteLine($"Item not found: {itemToRemove}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command. Please use +, -, or --.");
                }

                Console.WriteLine("Current list:");
                if (itemList.Count == 0)
                {
                    Console.WriteLine("[Empty]");
                }
                else
                {
                    foreach (string item in itemList)
                    {
                        Console.WriteLine("- " + item);
                    }
                }
            }
        }
    }
}
