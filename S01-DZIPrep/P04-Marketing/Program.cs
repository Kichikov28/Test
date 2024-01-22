using System;

namespace P04_Marketing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = int.Parse(Console.ReadLine());
            double billboard = budget * 2;
            double ads = 0.85 * billboard;
            double materials = (billboard + ads) / 7;
            double sum=billboard+ ads+materials+budget;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
