using System;

namespace P01_PrimeNumberss
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int num = 2;
            while (count < n)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                    count++;
                }
                num++;
            }
        }
       public static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
