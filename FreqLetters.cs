using System;
class FreqLetters
{
    static void Main()
    {
        String s = Console.ReadLine();
        char[] c = s.ToCharArray();
        Dictionary<char, int> letterCount = new Dictionary<char, int>();
        foreach (var l in c)
        {
            if (letterCount.ContainsKey(l))
            {
                letterCount[l]++;
            }
            else
            {
                letterCount[l] = 1;
            }
        }
        foreach (var item in letterCount)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}