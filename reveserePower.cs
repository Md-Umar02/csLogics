class Solution {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(ReverseExponentiation(n));
    }
    public static int ReverseExponentiation(int n)
    {
        int temp = n;
        int rev = 0;
        while (temp > 0)
        {
            int d = temp % 10;
            rev = rev * 10 + d;
            temp /= 10;
        }
        int res = 1;
        for (int i = 1; i <= rev; i++)
        {
            res *= n;
        }
        return res;
    }
}