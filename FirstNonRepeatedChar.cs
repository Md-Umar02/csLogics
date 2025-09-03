using System;
class FirstNonRepeatedChar
{
    static void Main()
    {
        string s = Console.ReadLine();
        char[] c = s.ToCharArray();
        NonRepeated(c);
    }
    static void NonRepeated(char[] c)
    {
        char temp = '\0';
        for (int i = 0; i < c.Length; i++)
        {
            bool isRepeated = false;
            for (int j = 0; j < c.Length; j++)
            {
                if (i != j && c[i] == c[j])
                {
                    isRepeated = true;
                    break;
                }
            }
            if (!isRepeated)
            {
                temp = c[i];
                break;
            }
        }
        Console.WriteLine(temp);
    }
}