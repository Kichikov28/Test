using System;
using System.Collections.Generic;

namespace P07_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
            foreach (var item in list)
            {
                sum += item;
                if (item > max)
                {
                    max = item;
                }
            }
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - (sum - max));
                Console.WriteLine($"No");
                Console.WriteLine($"Diff= {diff}");
            }
        }
    }
}
