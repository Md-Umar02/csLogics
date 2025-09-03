using System;
class DuplicateChar
{
    static void Main()
    {
        String s = Console.ReadLine();
        for (int i = 0; i < s.Length; i++)
        {
            bool exist = false;
            for (int k = 0; k < i; k++) // chk wheter element occured before to print duplicate one time
            {
                if (s[k] == s[i])
                {
                    exist = true;
                    break;
                }
            }
            if (exist) continue;
            bool isDup = false;
            for (int j = i+1; j < s.Length; j++)
            {
                if (s[i] == s[j] )
                {
                    isDup = true;
                    break;
                }
            }
            if(isDup)
            {
                Console.Write(s[i]);
            }
        }
    }
}