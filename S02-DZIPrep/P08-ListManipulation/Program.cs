using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_ListManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }
                string[] input=cmd.Split();
                switch (input[0])
                {
                    case "Add":
                        int num = int.Parse(input[1]);
                        numbers.Add(num);
                        break;
                    case "Remove":
                        int remmove = int.Parse(input[1]);
                        numbers.Add(remmove);
                        break;
                    case "RemoveAt":
                        int index = int.Parse(input[1]);
                        numbers.RemoveAt(index);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(input[1]);
                        int index1 = int.Parse(input[2]);
                        numbers.Insert(index1, numToInsert);
                        break;
                }

            }
        }
    }
}
