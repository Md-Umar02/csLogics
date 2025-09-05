using System;
class LastOccSubstring
{
    static void Main()
    {
        string haystack = Console.ReadLine();
        string needle = Console.ReadLine();
        int res = LastOcc(haystack, needle);
        Console.WriteLine(res);
    }
    static int LastOcc(string h, string n)
    {
        for (int i = h.Length - n.Length; i >= 0; i--)
        {
            bool match = true;
            for (int j = 0; j < n.Length; j++)
            {
                if (h[i + j] != n[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                return i;
            }
        }
        return -1;
    }
}