using System;
using System.Runtime.Intrinsics.Arm;
class vowels
{
    static void ain()
    {
        String str = Console.ReadLine();
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}