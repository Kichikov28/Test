using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0].ToLower() == "add")
                {
                    int people = int.Parse(input[1]);
                    wagons.Add(people);
                }
                else if (input[0].ToLower() == "end")
                {
                    Console.WriteLine(string.Join(", ", wagons));
                    break;
                }
                else
                {
                    int people = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i]+people<max)
                        {
                            wagons[i] += people;
                        }
                        break;
                    }
                }
            }

        }
    }
}
