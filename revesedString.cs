using System;

class StringReverser
{
    static void ain()
    {
        String str = Console.ReadLine();
        for (int i = str.Length-1; i >= 0; i--)
        {
            Console.WriteLine(str[i]);
        }
    }
}
