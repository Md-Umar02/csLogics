using System;
using System.Runtime.Serialization;
class swapWithoutTemp
{
    static void ain()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine();
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}