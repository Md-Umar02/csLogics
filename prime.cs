using System;
class prime
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        if (IsPrime(n))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        int c = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                c++;
            }
        }
        return c == 2;
    }
}