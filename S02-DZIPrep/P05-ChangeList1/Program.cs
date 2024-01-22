using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_ChangeList1
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
                string[] input = Console.ReadLine().Split(" ");
                if (input[0].ToLower() == "end")
                {
                    Console.WriteLine(string.Join(", ", nums));
                    break;
                }
                else if (input[0].ToLower() == "delete")
                {
                    int num = int.Parse(input[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i]==num)
                        {
                            nums.Remove(num);
                        }
                    }
                }
                else if (input[0].ToLower()=="insert")
                {
                    int element = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    nums.Insert(index, element);
                }
            }
        }
    }
}
