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
    public string Title{get; } // 
    private int _pages;
    public int pages
    {
        get => _pages;
        if ( ValueTask <= 0 )
                throw new ArgumentOutofException(nameof(value),"pages must be greater than zero.");
        _pages = ValueTask;
    }

}