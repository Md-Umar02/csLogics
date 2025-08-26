using System;
class TwoSumLeet
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int t = int.Parse(Console.ReadLine());
        int [] res = TwoSum(a, t);
        Console.WriteLine($"{res[0]}, {res[1]}");
    }
    static int[] TwoSum(int[] a, int t)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] + a[j] == t)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int [0];
    }
}