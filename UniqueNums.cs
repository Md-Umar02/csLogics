using System;
using System.Dynamic;
class UniqueNums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Unique(arr);
    }
    static void Unique(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            bool isUnique = true;
            for (int j = 0; j < a.Length; j++)
            {
                if (i != j && a[i] == a[j])
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
                Console.WriteLine(a[i] + " ");
            }
        }
    }
}