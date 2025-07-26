/*using System;
class Book
{
    public String Title;
    public String Author;
    public int Year;
    public double Price;
    public bool IsAvailable = true;
    public void GetDetails()
    {
        Console.WriteLine("Enter the book name");
        Title = Console.ReadLine();
        Console.WriteLine("Enter the Author name");
        Author = Console.ReadLine();
        Console.WriteLine("Enter the year");
        Year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the price");
        Price = int.Parse(Console.ReadLine());
    }
    public void DisplayDetails()
    {
        Console.WriteLine("\nBook Details:");
        Console.WriteLine($"Title       : {Title}");
        Console.WriteLine($"Author      : {Author}");
        Console.WriteLine($"Year        : {Year}");
        Console.WriteLine($"Price       : ₹{Price}");
    }
    public void BorrowBook()
    {
        if (IsAvailable == false)
        {
            Console.WriteLine("Available.");
        }
        else
        {
            Console.WriteLine("Not Available.");
        }
    }
    public void ReturnBook()
    {
        IsAvailable = true;
            Console.WriteLine("you returned the book");
    }
}
class Program
{
    static void Main()
    {
        Book bk = new Book();
        bk.GetDetails();
        bk.DisplayDetails();
        bk.BorrowBook();
        bk.ReturnBook();
    }
} */
using System;
using System.Collections.Generic;

class Book
{
    public string title;
    public string author;
    public int year;
    public decimal price;
    public bool isAvailable = true;

    public void DisplayDetails()
    {
        Console.WriteLine("---------------");
        Console.WriteLine($"Title       : {title}");
        Console.WriteLine($"Author      : {author}");
        Console.WriteLine($"Year        : {year}");
        Console.WriteLine($"Price       : ₹{price}");
        Console.WriteLine($"Available   : {(isAvailable ? "Yes" : "No")}");
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"\"{title}\" has been borrowed.");
        }
        else
        {
            Console.WriteLine($"\"{title}\" is currently not available.");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine($"\"{title}\" has been returned.");
    }

    public void ApplyDiscount(decimal percent)
    {
        if (percent > 0 && percent <= 100)
        {
            price -= price * (percent / 100);
            Console.WriteLine($"Discount applied. New price: ₹{price}");
        }
        else
        {
            Console.WriteLine("Invalid discount percentage.");
        }
    }
}

class Library
{
    public List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"\"{book.title}\" added to library.");
    }

    public void RemoveBook(string title)
    {
        Book b = FindBookByTitle(title);
        if (b != null)
        {
            books.Remove(b);
            Console.WriteLine($"\"{title}\" removed from library.");
        }
        else
        {
            Console.WriteLine($"\"{title}\" not found.");
        }
    }

    public Book FindBookByTitle(string title)
    {
        foreach (Book b in books)
        {
            if (b.title.Equals(title, StringComparison.OrdinalIgnoreCase))
                return b;
        }
        return null;
    }

    public void ListAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("\n📚 Books in Library:");
        foreach (Book b in books)
        {
            b.DisplayDetails();
        }
    }
}

class Program
{
    static void ain()
    {
        Library library = new Library();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n===== Library Menu =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Apply Discount");
            Console.WriteLine("6. List All Books");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option (1-7): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Book newBook = new Book();
                    Console.Write("Enter title: ");
                    newBook.title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    newBook.author = Console.ReadLine();
                    Console.Write("Enter year: ");
                    newBook.year = int.Parse(Console.ReadLine());
                    Console.Write("Enter price: ");
                    newBook.price = decimal.Parse(Console.ReadLine());
                    library.AddBook(newBook);
                    break;

                case "2":
                    Console.Write("Enter title to remove: ");
                    string removeTitle = Console.ReadLine();
                    library.RemoveBook(removeTitle);
                    break;

                case "3":
                    Console.Write("Enter title to borrow: ");
                    string borrowTitle = Console.ReadLine();
                    Book bookToBorrow = library.FindBookByTitle(borrowTitle);
                    if (bookToBorrow != null)
                        bookToBorrow.BorrowBook();
                    else
                        Console.WriteLine("Book not found.");
                    break;

                case "4":
                    Console.Write("Enter title to return: ");
                    string returnTitle = Console.ReadLine();
                    Book bookToReturn = library.FindBookByTitle(returnTitle);
                    if (bookToReturn != null)
                        bookToReturn.ReturnBook();
                    else
                        Console.WriteLine("Book not found.");
                    break;

                case "5":
                    Console.Write("Enter title to apply discount: ");
                    string discountTitle = Console.ReadLine();
                    Book bookToDiscount = library.FindBookByTitle(discountTitle);
                    if (bookToDiscount != null)
                    {
                        Console.Write("Enter discount percent: ");
                        decimal percent = decimal.Parse(Console.ReadLine());
                        bookToDiscount.ApplyDiscount(percent);
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                    break;

                case "6":
                    library.ListAllBooks();
                    break;

                case "7":
                    exit = true;
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
