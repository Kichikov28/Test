using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P06_ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", list));
                    break;
                }
                else if (input[0] == "Add")
                {
                    int num = int.Parse(input[1]);
                    list.Add(num);
                }
                else if (input[0] == "Remove")
                {
                    int index = int.Parse(input[1]);
                    if (index > list.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index!");
                    }
                    list.RemoveAt(index);
                }
                else if (input[0] == "Insert")
                {
                    int element = int.Parse(input[1]);
                    int index = int.Parse(input[2]);
                    list.Insert(index, element);
                }
                else if (input[0] == "Shiftleft")
                {
                    int count = int.Parse(input[1]);
                    for (int i = 0; i < count; i++)
                    {
                        int number = list[0];
                        list.RemoveAt(0);
                        list.Add(number);
                    }
                }
                else if (input[0] == "Shiftright")
                {
                    int count = int.Parse(input[1]);
                    for (int i = 0; i < count; i++)
                    {
                        int number = list[list.Count - 1];
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0, number);

                    }
                }
            }
        }
    }
}
