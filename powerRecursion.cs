using System;
class powerRecursion
{
    static void ain()
    {
        int b = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int res = power(b, e);
        Console.WriteLine(res);
    }
    static int power(int b, int e)
    {
        if (e == 0) return 1;
        return b * power(b , e - 1);
    }
}