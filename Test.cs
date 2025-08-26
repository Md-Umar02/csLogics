using System;
using System.Globalization;


class test
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        char rep = '\0';
        for (int i = 0; i < c.Length; i++)
        {
            for (int j = 1; j < c.Length; j++)
            {
                if (c[i] != c[j])
                {
                    rep = c[i];
                }
            }
        }
        Console.WriteLine(rep);
    }
}