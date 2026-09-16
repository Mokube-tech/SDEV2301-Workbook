// Book book1 = new Book();
Book book1 =  new Book("The Hobbit", "J.R.R. Tolkien");
// book1.Title = "The Hobbit";
// book1.Author = "J.R.R Tolken";
Console.WriteLine(book1.Title);
class Book
{
    public string Title{ get; set; } = "";
    public string Author{ get; set; } = "";

    public Book( string title, string author)

    {
        this.Title = title;
        this.Author = author;
    }
    public void PrintSummary()

    {
        Console.WriteLine($"{Title} by {Author}");
    }
}