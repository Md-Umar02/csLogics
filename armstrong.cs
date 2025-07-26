using System.Runtime.CompilerServices;

class Armstrong
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        if (isArmstrong(n))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
    static bool isArmstrong(int n)
    {
        int digits = n.ToString().Length;
        int sum = 0;
        int o = n;
        while (n > 0)
        {
            int d = n % 10;
            int p = 1;
            for (int i = 0; i < digits; i++)
            {
                p *= d;
            }
            sum += p;
            n /= 10;
        }
        return sum == o;
    }
}