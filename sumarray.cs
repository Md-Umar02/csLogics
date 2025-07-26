using System;
class sumarray
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        sum(arr);
    }
    static void sum(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            count += arr[i];
        }
        Console.WriteLine(count);    
    }
}    