using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class StudentMarks
{
    public static void ain()
    {
        Dictionary<string, int> studentMarks = new Dictionary<string, int>();
        Console.Write("No. of students");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Marks: ");
            int marks = int.Parse(Console.ReadLine());
            studentMarks.Add(name, marks);
        }
        foreach (var i in studentMarks)
        {
            Console.WriteLine(i.Key + " : " + i.Value);
        }
    }
}