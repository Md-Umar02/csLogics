using System;
using System.Dynamic;
class duplicates
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        GetDup(arr);
    }
    static void GetDup(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            bool exist = false;
            for (int k = 0; k < i; k++) // chk wheter element occured before to print duplicate one time
            {
                if (a[k] == a[i])
                {
                    exist = true;
                    break;
                }
            }
            if (exist) continue;
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    Console.WriteLine(a[i]);
                    break;
                }
            }
        }
    }
}