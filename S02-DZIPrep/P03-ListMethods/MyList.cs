using System;
using System.Collections.Generic;
using System.Text;

public class MyList
{
    public static List<int> GetRandomNumbers(int n, int max, int min)
    {
        List<int> list = new List<int>();
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNum = random.Next(min, max);
            list.Add(randomNum);
        }
        return list;
    }
    public static List<bool> GetBools(int n)
    {
        List<bool> bools = new List<bool>();
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            bools.Add(random.Next(0, 2) == 0 ? false : true);
        }
        return bools;
    }
    public static int GetMax(List<int> list)
    {
        int max = int.MinValue;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        return max;
    }
    public static int GetSecondMax(List<int> list)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (max > secondMax && list[i]<max)
            {
                secondMax = list[i];
            }
        }
        return secondMax;
    }
    public static int AverageSum(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return sum/list.Count;
    }
    public static int AbsoluteSum(List<int> list)
    {
        int absoluteSum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i]<0)
            {
                absoluteSum += (list[i] * -1);
            }
            else
            {
                absoluteSum += list[i];
            }
        }
        return absoluteSum;
    }
    public static int GetDevBy3AndBiggerThan15(List<int> list)
    {
        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 3 == 0 && list[i] > 15)
            {
                sum += list[i];
            }
        }
        return sum;
    }
    public static List<int> GetList(List<int> list)
    {
        List<int>sec=new List<int>();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 3 == 0 && list[i] > 15)
            {
                sec.Add(list[i]);
            }
        }
        return sec;
    }

}
