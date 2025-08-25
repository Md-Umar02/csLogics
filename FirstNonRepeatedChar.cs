using System;
class FirstNonRepeatedChar
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        char rep = '\0';
        for (int i = 0; i < c.Length; i++)
        {
            bool isRepeated = false;
            for (int j = 0; j < c.Length; j++) //to check repeated value
            {
                if (i != j && c[i] == c[j])
                {
                    isRepeated = true;
                    break;
                }
            }
            if(!isRepeated)
            {
                rep = c[i];
                break;
            }
        }
        Console.WriteLine(rep);
    }
}