using System;
class frequency
{
    static void ain()
    {
        String str = Console.ReadLine();
        char c = char.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}