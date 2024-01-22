using System;
using System.Collections.Generic;

namespace P03_ListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = MyList.GetRandomNumbers(5, 10, -10);
            //list.Sort();
            //Console.WriteLine(string.Join(", ",list));
            List<int>list= new List<int> { 1,-2,27,2,1,18};
            list.Sort();
            Console.WriteLine( string.Join(", ",list) );
            //Console.WriteLine(MyList.GetSecondMax(list));
            Console.WriteLine(  string.Join(", ",MyList.GetList(list)));
        }
    }
}
