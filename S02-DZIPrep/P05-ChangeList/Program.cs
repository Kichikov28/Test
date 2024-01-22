using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int>nums=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0].ToLower()=="end")
                {
                    Console.WriteLine(string.Join(" ",nums));
                    break;
                }
                else if (input[0].ToLower()=="delete")
                {
                    int num = int.Parse(Console.ReadLine());
                    nums.Remove(num);
                }
            }
        }
    }
}
