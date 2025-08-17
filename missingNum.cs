using System.Dynamic;

class missingNum
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int res = getMissingNum(arr);
        Console.WriteLine(res);
    }
    static int getMissingNum(int[] arr)
    {
        int n = arr.Length + 1;
        int tot = n * (n + 1) / 2;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        return tot - sum;
    }
}