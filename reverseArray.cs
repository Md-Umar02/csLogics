using System;
class reverseArray
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - 1 - i];
            arr[n - 1 - i] = temp;
        }
        for (int i = 0; i < n; i++)
        {
                Console.WriteLine(arr[i]);
        }
    }
}