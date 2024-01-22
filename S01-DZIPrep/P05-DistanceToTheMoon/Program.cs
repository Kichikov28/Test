using System;

namespace P05_DistanceToTheMoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed=double.Parse(Console.ReadLine());   
            double littersFuel=double.Parse(Console.ReadLine());
            double km = 384400 * 2;
            double time =Math.Ceiling( km / speed);
            double totalTime = time + 3;
            double fuel = (littersFuel * km) / 100;
            Console.WriteLine(totalTime);
            Console.WriteLine(fuel);
        }
    }
}
