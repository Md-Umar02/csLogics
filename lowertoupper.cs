class Lower
{
    static void ain()
    {
        String str = Console.ReadLine();
        String res = "";
        for (int i = 0; i < str.Length; i++)
        {
            char C = str[i];
            if (C >= 'a' && C <= 'z')
            {
                res += (char)(C - 32);
            }
            else
            {
                res += C;
            }
        }
        Console.WriteLine(res);
    }
}