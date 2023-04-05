using ConsoleApp1;

namespace TestProject1;

public class UnitTestBookDatabase
{

    [SetUp]
    public void Setup()
    {
        var book1 = new Book("The great Gatsby");
        var book2 = new Book("Frankenstein");
        
        BookDatabase.Instance.RegisterNewBook(book1);
        BookDatabase.Instance.RegisterNewBook(book2);
    }
    
    [Test]
    public void Subscribe()
    {
        List<string> notifications = new List<string>();

        BookDatabase.Instance.NotifySubscribers += book => notifications.Add(book.ToString());
        
        BookDatabase.Instance.AdvocateNewBooks();
        
        Assert.That(notifications.Count(), Is.EqualTo(2));
    }
}