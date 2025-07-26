using System;
using System.Globalization;
class max
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int l = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > l)
            {
                l = arr[i];
            }
        }
        Console.WriteLine(l);
    }
}