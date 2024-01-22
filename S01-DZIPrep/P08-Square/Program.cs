using System;

namespace P08_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            
            while (n>10)
            {
                int sum = 0;
                while (n>0)
                {
                    sum += n % 10;
                    n/= 10;
                }
                n = sum;
            }
            Console.WriteLine(n);

        }
    }
}
