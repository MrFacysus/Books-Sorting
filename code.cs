Console.WriteLine("Ime \t Autor \t Godina izdanja\n");
List<string> inputs = new List<string>();
string input = Console.ReadLine();
List<Book> books = new List<Book>();

while (input.Length > 0)
{
    inputs.Add(input);
    input = Console.ReadLine();
}

foreach(string inp in inputs)
{
    books.Add(new Book(inp));
}

books = books.OrderBy(x => x.Year).ToList();

foreach (Book book in books)
{
    Console.WriteLine($"{ book.Name } {book.Author} {book.Year}");
}

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string input)
    {
        Name = input.Split(' ')[0];
        Author = input.Split(' ')[1];
        Year = int.Parse(input.Split(' ')[2]);
    }
}
