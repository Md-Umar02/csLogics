using System;
using System.Globalization;


class test
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        int l = 0;
        int r = s.Length - 1;
        while (l > r)
        {
            char temp = c[l];  //we cannot change or alocate ne value to string because its immutable
            c[l] = c[r];
            c[r] = temp;
            l++;
            r--;
        }
        String rev = new string(c);
        Console.WriteLine(rev);
    }
}