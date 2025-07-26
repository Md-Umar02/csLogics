using System;
class factorial
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        int fact = 1;
        while (n > 0)
        {
            fact *= n;
            n--;
        }
        Console.WriteLine(fact);
    }
}