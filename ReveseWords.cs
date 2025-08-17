using System;
class ReveseWords
{
    static void ain()
    {
        String str = Console.ReadLine();
        String[] words = str.Split(' ');
        String rev = "";
        for (int i = words.Length; i > 0; i--)
        {
            rev += words[i];
        }
        Console.WriteLine(rev.Trim());
    }
}