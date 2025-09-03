using System;
class MoveNegativeNum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        GetNums(arr);
        Console.WriteLine(string.Join(", ", arr));
    }
    static void GetNums(int[] a)
    {
        int k = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] >= 0)
            {
                a[k] = a[i];
                k++;
            }
        }
        for (int i = k; i < a.Length; i++)
        {
            if (a[i] < 0)
            {
                a[k] = a[i];
                k++;
            }
        }
    }
}