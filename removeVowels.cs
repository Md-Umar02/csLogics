using System;
class removeVowels
{
    static void Main()
    {
        String str = Console.ReadLine();
        String res = "";
        for (int i = 0; i <= str.Length; i++)
        {
            char ch = str[i];
            if (ch != 'A' && ch != 'E' && ch != 'I' && ch != 'O' && ch != 'U' && ch != 'a'
                && ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u')
            {
                res += str[i];
            }
        }
        Console.WriteLine(res);
    }
}