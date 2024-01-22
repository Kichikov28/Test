using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> products= new Dictionary<string,double>();
            string input;
            double totalPrice = 0;
            while ((input=Console.ReadLine())!="Stop shopping")
            {
                string[]productsInfo=input.Split('-').ToArray();
                string name = productsInfo[0];
                double price = double.Parse(productsInfo[1]);
                if (products.ContainsKey(name))
                {
                    products[name] += price;
                }
                else
                {
                    products.Add(name, price);
                }
            }
            foreach (var item in products.OrderBy(x=>x.Value))
            {
                totalPrice += item.Value;
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
            Console.WriteLine($"Total sum: {totalPrice:f2}");
        }
    }
}
