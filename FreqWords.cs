using System;
class FreqWords
{
    static void Main()
    {
        String s = Console.ReadLine();
        String[] words = s.ToLower().Split();
        Dictionary<string, int> wordsCount = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (wordsCount.ContainsKey(word))
            {
                wordsCount[word]++;
            }
            else
            {
                wordsCount[word] = 1;
            }
        }
        foreach (var item in wordsCount)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}