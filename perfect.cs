class PerfectNum
{
    static void ain(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (Perfect(n))
        {
            Console.WriteLine("y");
        }
        else
        {
            Console.WriteLine("n");
        }
    }
    static bool Perfect(int n)
    {
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum == n;
    }
}