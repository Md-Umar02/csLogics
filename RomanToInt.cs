using System;
using System.Collections.Generic;
class RomanToInt
{
    static void Main()
    {
        String s = Console.ReadLine();
        int num = GetInt(s);
        Console.WriteLine(num);
    }
    public static int GetInt(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int val = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (map[s[i]] < map[s[i + 1]])
            {
                val -= map[s[i]];
            }
            else
            {
                val += map[s[i]];
            }
        }
        val += map[s[s.Length - 1]];
        return val;
    }
}