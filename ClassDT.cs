/*
using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}
class Library
{
    private readonly Book _book;
    public Library(Book bk)
    {
        _book = bk;
    }
    public void ShowDet()
    {
        Console.WriteLine($"Title: {_book.Title}, Author: {_book.Author}");
    }
}
class Program
{
    static void Main()
    {
        Book bk = new Book
        {
            Title = "abc",
            Author = "def"
        };
        Library l = new Library(bk);
        l.ShowDet();
    }
}*/
//class static method
using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}
class Library
{
    private  static Book _book;
    public Library(Book bk)
    {
        _book = bk;
    }
    public static void ShowDet()
    {
        Console.WriteLine($"Title: {_book.Title}, Author: {_book.Author}");
    }
}
class Program
{
    static void Main()
    {
        Book bk = new Book
        {
            Title = "abc",
            Author = "def"
        };
        Library l = new Library(bk);
        Library.ShowDet();
    }
}
