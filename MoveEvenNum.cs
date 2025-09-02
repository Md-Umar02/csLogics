using System;
class MoveEvenNum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        EvenNum(arr);
        Console.WriteLine(string.Join(", ",arr));
    }
    static void EvenNum(int[] arr)
    {
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                arr[k] = arr[i];
                k++;
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                arr[k] = arr[i];
                k++;
            }
        }
    }
}