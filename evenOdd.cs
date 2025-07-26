using System;
class evenOdd
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
        Console.WriteLine("Even");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }    
}
/*{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int odd = isOdd(arr);
        int even = isEven(n);
        Console.WriteLine(odd);
        Console.WriteLine(even);
    }
    static int isOdd(int[] arr)
    {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                
            }
        }
    }
} */