using System;
class longestWord
{
    static void Main()
    {
        String s = Console.ReadLine();
        String l = Longest(s);
        Console.WriteLine(l);
    }
    static String Longest(String s)
    {
        String[] words = s.Split();
        String longer = "";
        foreach (var word in words)
        {
            if (word.Length > longer.Length)
            {
                longer = word;
            }
        }
        return longer;
    }
}