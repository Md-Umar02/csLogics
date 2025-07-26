using System;
class anagram
{
    static void ain()
    {
        String str1 = Console.ReadLine();
        String str2 = Console.ReadLine();
        if (isAnagram(str1, str2))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
    static bool isAnagram(string a, string b)
    {
        if (a.Length != b.Length) return false;
        int[] freq = new int[256];
        for (int i = 0; i < a.Length; i++)
        {
            freq[a[i]]++;
            freq[b[i]]--;
        }
        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] == 0)
                return true;
        }
        return false;
    }
}