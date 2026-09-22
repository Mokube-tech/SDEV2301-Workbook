class Program
{
    static void Main()
    {
        Book book = new Book("Clean Code", 464);
        book.pages = 500;
        Console.WriteLine($"{book.Title}: {book.pages} pages");
    }
}

class Book
{
    public string Title{get; }
    public int pages{get; set;}
    public Book( string title, int pages)
    {
        Title = title; pages = pages;
    }
}