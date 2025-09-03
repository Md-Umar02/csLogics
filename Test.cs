using System;
class Test
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        int left = 0;
        int right = c.Length - 1;
        rev(c, left, right);
        string reversed = new string(c);
        Console.WriteLine(reversed);
    }
    static void rev(char[] c, int l, int r)
    {
        if (l >= r)
            return;
        char temp = c[l];
        c[l] = c[r];
        c[r] = temp;
        rev(c, l + 1, r - 1);
    }
}