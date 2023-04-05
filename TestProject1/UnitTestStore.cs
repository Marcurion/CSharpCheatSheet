using ConsoleApp1;

namespace TestProject1;


public class UnitTestStore
{


    [Test]
    public void TestStore()
    {
        var store = new Bookstore();
        var book1 = new Book("Book1", "1234");
        store.AddBook(book1);
        store.AddBook(book1);

        Assert.That(store.ReturnNumberOfBooks(), Is.EqualTo(2));
        
        store.RemoveLastBook();
        Assert.That(store.ReturnNumberOfBooks(), Is.EqualTo(1));
        store.RemoveLastBook();
        Assert.That(store.ReturnNumberOfBooks(), Is.EqualTo(0));
        
        // run on empty store
        Assert.Throws<ArgumentOutOfRangeException>(() => store.RemoveLastBook());
        Assert.Zero(store.ReturnNumberOfBooks());
        
    }
    
}