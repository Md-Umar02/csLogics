using System;
class rev
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        int left = 0;
        int right = c.Length - 1;
        while (left < right)
        {
            char temp = c[left];
            c[left] = c[right];
            c[right] = temp;
            left++;
            right--;
        }
        String rev = new string(c);
        Console.WriteLine(rev);
    }
}