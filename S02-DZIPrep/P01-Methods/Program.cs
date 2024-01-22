using System;

namespace P01_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = MyArray.MinMax(5, 18, 5);
            Console.WriteLine(  string.Join(", ",arr));
        }
    }
}
