using System;
class fibinocci
{
    static void Sain()
    {
        int n = int.Parse(Console.ReadLine());
        getFibinocci(n);
    }
    static void getFibinocci(int n)
    {
        int a = 0;
        int b = 1;
        int c = 0;
        if (n >= 1) Console.WriteLine(a);
        if(n>=2) Console.WriteLine(", "+b);
        for (int i = 3; i < n; i++)
        {
            c = a + b;
            Console.WriteLine(", " + a);
            a = b;
            c = a;
        }
    }
}