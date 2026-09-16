// Book book1 = new Book();
// Book book1 =  new Book("The Hobbit", "J.R.R. Tolkien");
// book1.Title = "The Hobbit";
// book1.Author = "J.R.R Tolken";
// Console.WriteLine(book1.Title)

Book book2 = new Book("Dune", "Frank Herbert");
book1.Title = "The Hobbit - Updated";
book1.pages = 555;
book1.PrintSummary();
book2.PrintSummary();
class Book
{
      // public int pages; // field
    public int Pages { get; set; }  // auto-implemented property
    public string Title{ get; set; } = "";
    public string Author{ get; set; } = "";
   
   
    
    public Book( string title, string author, int pages = 0)

    {
        this.Title = title;
        this.Author = author;
        this.Pages = pages;
    }
    public void PrintSummary()

    {
        Console.WriteLine($"{Title} by {Author}");
    }
    
    
}