using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_RemoveNegativeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            nums.RemoveAll(x => x < 0);
            nums.Reverse();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
