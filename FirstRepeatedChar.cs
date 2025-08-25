using System;
using System.Reflection.Metadata;


class RepeatedChar
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        char rep = '\0';
        for (int i = 0; i < c.Length; i++)
        {
            bool isRepeated = false;
            for (int j = 0; j < c.Length; j++)
            {
                if (i != j && c[i] == c[j])
                {
                    rep = c[i];
                    break;
                }
            }
        }
        Console.WriteLine(rep);
    }
}