using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_MarketingSoftware
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item(15, "kolelo", 180.23m, 5, 3));
            items.Add(new Item(10, "kola", 25000m, 2, 1));
            items.Add(new Item(15, "motor", 4000m, 1, 4));
            //1
            DisplayItems(GetItemsOrderedByName(items));
            //2
            Console.WriteLine();
            GetItemsByType(items, 3);
            //3
            Console.WriteLine();
           GetItemsAveragePrice(items,5);
        }
        public static List<Item> GetItemsOrderedByName(List<Item> items)
        {
            return items.OrderBy(x => x.Name).ToList();
        }
        public static void DisplayItems(List<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void GetItemsByType(List<Item> items, int type)
        {
            List<Item> sorted= items.Where(x => x.ItemType == type).OrderBy(x => x.TotalValue()).ToList();
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.ToString()} {item.TotalValue()} lv.");
            }
        }
        public static void GetItemsAveragePrice(List<Item> items, int type)
        {
            List<Item> sorted = items.Where(x => x.ItemType == type).ToList();
            if (sorted.Count>=1)
            {
                decimal averagePrice = sorted.Average(x => x.Price);
                decimal totalValue = sorted.Sum(x => x.TotalValue());
                Console.WriteLine($"Price: {averagePrice:f2}, TotalValue: {totalValue:f2}");
            }
            else
            {
                Console.WriteLine("No items from this type");
            }

        }

    }

}
