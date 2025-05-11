namespace BookDetails;
//Create a Book class with Title, Author, Price, and Category and method to display the book's details.
public class BookData
{
    public string title{get; set;}
    public string author{get; set;}
    public decimal price{get; set;}
    public string category{get; set;}
    public void DisplayDetails()
    {
        Console.WriteLine($"Title-----> {title}");
        Console.WriteLine($"Author----> {author}");
        Console.WriteLine($"Price-----> {price}");
        Console.WriteLine($"Category--> {category}");
    }
}