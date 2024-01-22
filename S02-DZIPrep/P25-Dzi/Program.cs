using System;

namespace P25_Dzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Count numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[]arr=new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<1)
                {
                    Console.WriteLine("Incorectly entered number!");
                }
                else if (num>=1)
                {
                    arr[i] = num;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(count);

        }
    }
}
