public class Book
{
    // Properties
    public string BookID {get; set;}
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublishedYear {get; set;}
    public bool Availability {get; set;}

    // Constructor
    public Book(string BookID, string Title, string author, string PublishedYear, bool Availability)
    {
        this.BookID = BookID;
        this.Title = Title;
        this.Author = author;
        this.PublishedYear = PublishedYear;
        this.Availability = Availability;
    }
}
