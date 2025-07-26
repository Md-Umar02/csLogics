using System;
class duplicates
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Duplicates");
        dup(arr);
    }
    static void dup(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool isDup = false;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] == arr[j])
                {
                    isDup = true;
                    break;
                }
            }
            if (!isDup)
            {
                Console.Write(arr[i]);
            }
        }
    }
}