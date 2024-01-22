using System;
public class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[70];
        int sum = 0;
        Random random = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-200, 200);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (GetMaxElement(arr) > arr[i] && arr[i] > GetMinElement(arr))
            {
                sum += arr[i];
            }
        }
        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine(sum);

    }
    public static int GetMaxElement(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
    public static int GetMinElement(int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        return min;
    }
}

