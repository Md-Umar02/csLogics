using System;
class leapYear
{
    static void ain()
    {
        int n = int.Parse(Console.ReadLine());
        if (isLeapYear(n))
        {
            Console.WriteLine("y");
        }
        else
        {
            Console.WriteLine("n");
        }
    }
    static bool isLeapYear(int n)
    {
        if (n % 400 == 0) return true;
        else if (n % 100 == 0) return false;
        else if (n % 4 == 0) return true;
        else return false;
    }
}