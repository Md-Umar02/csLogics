using System;
using Microsoft.Win32;
class palindrome
{
    static void ain()
    {
        String str = Console.ReadLine().ToLower();
        if (isPal(str))
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not");
        }
    }
    static bool isPal(String str)
    {
        String rev = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i]; 
        } 
        return str.Equals(rev);
    }
}