using System;
using System.Diagnostics.SymbolStore;
class secondLargest
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("enter correctly");
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int res = getSecondLargest(arr);
        Console.WriteLine(res);
    }
    static int getSecondLargest(int[] arr)
    {
        int l = arr[0];
        int sl = -1;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > l)
            {
                sl = l;
                l = arr[i];
            }
            else if (arr[i] > sl && arr[i] < l)
            {
                sl = arr[i];
            }
        }
        return sl;
    }
}