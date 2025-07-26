using System;
class bill
{
    static void ain()
    {
        Console.WriteLine("Enter number of pizzas bought:");
        int pz = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of puffs bought:");
        int pf = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of cool drinks bought:");
        int cd = int.Parse(Console.ReadLine());
        Console.WriteLine("Bill Details:");
        Console.WriteLine("Pizzas: " + pz + " * 100 = " + pz * 100);
        Console.WriteLine("Puffs: " + pf + " * 20 = " + pf * 20);
        Console.WriteLine("Cool drinks: " + cd + " * 10 = " + cd * 10);
        int tot = pz * 100 + pf * 20 + cd * 10;
        Console.WriteLine("Total: " + tot);
    }
}