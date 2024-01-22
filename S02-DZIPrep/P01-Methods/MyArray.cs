using System;
using System.Collections.Generic;
using System.Text;

public class MyArray
{
    public static int[] MinMax(int n, int max, int min)
    {
        int[]arr=new int[n];
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = r.Next(min, max);
        }
        return arr;

    }
    public static bool[]RandomBools(int n)
    {
        bool[]arr=new bool[n];

        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i]=r.Next(-5,5)<0?false:true;
        }
        return arr;
    }
    public static int GetMaxElement(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
        }
        return max;
    }
    public static int GetSecondLargestElement(int[] array)
    {
        int max=int.MinValue;
        int secondLargest = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>max)
            {
                max = array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > secondLargest && array[i]<max)
            {
                secondLargest = array[i];
            }
        }
        return secondLargest;
    }
    public static double AverageSum(int[]array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum/array.Length;
    }
    public static int AbsoluteSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0)
            {
                sum+=array[i]*(-1);
            }
            else
            {
                sum += array[i];
            }
        }
        return sum;
    }
    public static int SumBy3AndBiggerThan15(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i]>15)
            {
                sum += array[i];
            }
        }
        return sum;
    }
    public static int[] DevBy3AndBiggerThan15(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i] > 15)
            {
                count++;
            }
        }
        int[] el = new int[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i] > 15)
            {
                el[index] = array[i];
                index++;
            }
        }
        return el;
    }
    public static int CountAboveAverage(int[]array)
    {
        int sum = 0;
        int count = 0;
        double sum2 = 0;
        double averageSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                sum += array[i] * (-1);
            }
            else
            {
                sum += array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            averageSum += array[i];
        }
        sum2 += averageSum / array.Length;
        if (sum>sum2)
        {
            count++;
        }
        return count;
    }
    public static int[] AddUpTo10(int[] array)
    {
        int[] changedArr=new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            changedArr[i] = 10 - array[i];
        }
        return changedArr;
    }
}

