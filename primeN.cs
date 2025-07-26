using System;
class primeN
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        Primes(n);
    }
    static void Primes(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool IsPrime(int i)
    {
        if (i <= 1) return false;
        int count = 0;
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {
                count++;
            }
        }
        return count == 2;
    }
}