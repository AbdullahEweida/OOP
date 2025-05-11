//*Create a Book class with Title, Author, Price, and Category and method to display the book's details.
//*Then find books that belong to a specific category and have a price greater than 100.
//*Group books by their category and calculate the total price for each category. 
//*?Find the book with the highest price in each category.
using BookDetails;

List <BookData> booksData = new List<BookData> {
    new BookData {title = "The wild robot", author = "Peter Brown", category= "Adnenture",price = (decimal)124.99},
    new BookData {title = "Charlotte's web", author = "E.B. white", category= "Adnenture",price = (decimal)244.99},
    new BookData {title = "The Lion", author = "C.S. Lewis", category= "Adnenture",price = (decimal)99.99},
    new BookData {title = "Al-Ayyam", author = "Taha Hussein", category= "Classic Literature",price = (decimal)24.99},
    new BookData {title = "Pride and Prejudice", author = "Jane Austen", category= "Classic Literature",price = (decimal)99.99},
    new BookData {title = "Influence", author = "R.B. Cialdini", category= "Psychology",price = (decimal)149.99},
    new BookData {title = "Daring Greatly", author = "Brene` Brown", category= "Psychology",price = (decimal)159.99}
};

Console.WriteLine("\tFind function(\"Adnenture\")");
var catClassic = booksData.Where(c => (c.category.Contains("Adnenture")) && (c.price > 100));
foreach (var item in catClassic)
{
    Console.WriteLine("----------------------------------");
    item.DisplayDetails();
    Console.WriteLine("----------------------------------");
}

Console.WriteLine("\n\tGroup by function");
var gBooks = booksData.GroupBy(b => b.category);
foreach (var gItem in gBooks)
{
    Console.WriteLine($"Category : {gItem.Key} , Price {gItem.Sum(g => g.price)}");
    foreach (var item in gItem)
    {
        Console.WriteLine($"---->Title : {item.title} , Price : {item.price}");
    }
    Console.WriteLine("+++++++++++++++++++++++++++++++");
}
Console.WriteLine("\n\tFind highest pirce function");
foreach (var gItem in gBooks)
{
    decimal bMax = gItem.Max(g => g.price);
    Console.WriteLine($"Category : {gItem.Key} , Price {bMax}");
    foreach (var item in gItem)
    {
        if (item.price == bMax)
        {
            item.DisplayDetails();
        }
    }
    Console.WriteLine("+++++++++++++++++++++++++++++++");
}

