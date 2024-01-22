using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0].ToLower() == "end")
                {
                    break;
                }

                ProcessCommand(nums, input);
            }
        }

        static void ProcessCommand(List<int> nums, string[] input)
        {
            switch (input[0].ToLower())
            {
                case "contains":
                    int numToCheck = int.Parse(input[1]);
                    if (nums.Contains(numToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "printeven":
                    var evenNums = nums.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ", evenNums));
                    break;

                case "printodd":
                    var oddNums = nums.Where(x => x % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ", oddNums));
                    break;

                case "getsum":
                    var sum = nums.Sum();
                    Console.WriteLine(sum);
                    break;

                case "filter":
                    string condition = input[1];
                    int numToCompare = int.Parse(input[2]);
                    var filteredNums = FilterNumbers(nums, condition, numToCompare);
                    Console.WriteLine(string.Join(" ", filteredNums));
                    break;
            }
        }

        static List<int> FilterNumbers(List<int> nums, string condition, int numToCompare)
        {
            switch (condition)
            {
                case "<":
                    return nums.Where(x => x < numToCompare).ToList();

                case ">":
                    return nums.Where(x => x > numToCompare).ToList();

                case ">=":
                    return nums.Where(x => x >= numToCompare).ToList();

                case "<=":
                    return nums.Where(x => x <= numToCompare).ToList();

                default:
                    return new List<int>();
            }
        }
    }
}
