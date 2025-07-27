class Split
{
    static void ain()
    {
        String str = Console.ReadLine();
        String[] words = str.Split();
        for (int i = 0; i <= words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}