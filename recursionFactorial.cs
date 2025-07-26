using System;
class recursionFactorial
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int res = fact(n);
        Console.WriteLine(res);
    }
    static int fact(int n)
    {
        if ( n == 0 ||n == 1)
        {
            return 1;
        }
        return n * fact(n - 1);
    }
}