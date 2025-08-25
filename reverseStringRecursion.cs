using System;
class reverseStringRecursion
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        Rev(c, 0, c.Length - 1);
        String reversed = new string(c);
        Console.WriteLine(reversed);
    }
    static void Rev(char[] arr, int l, int r)
    {
        if (l >= r)
        {
            return;
        }
        char temp = arr[l];
        arr[l] = arr[r];
        arr[r] = temp;
        Rev(arr, l + 1, r - 1); 
    }
}