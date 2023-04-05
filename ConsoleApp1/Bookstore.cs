namespace ConsoleApp1;

public class Bookstore
{
    private List<Book> _books;

    public Bookstore()
    {
        _books = new List<Book>();
    }
    

    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void RemoveLastBook()
    {
        try
        {
            _books.RemoveAt(_books.Count - 1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw e;
        }

    }

    public int ReturnNumberOfBooks()
    {
        return _books.Count;
    }
}