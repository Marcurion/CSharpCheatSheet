using ConsoleApp1;

namespace TestProject1;

public class UnitTestBooks
{
    private Book _book;

    [SetUp]
    public void Setup()
    {
        _book = new Book("Great Gatsby", uuid:"123");
    }
    
    [Test]
    public async Task AsyncCalls()
    {
        
        var result = await _book.DownloadDescriptionAsync();
        
        Assert.That(result, Is.GreaterThan(10));
        
    }
    
    [Test]
    public void NullablePrimitives()
    {

        var result = _book.GetQuoteNumber(4);
        
        Assert.That(result, Is.Null);
        
    }
    
    [Test]
    public void CombiningNullableAndNotNullable()
    {
        int? result = 10;

        result = result + _book.GetQuoteNumber(1)?.Length;
        Assert.That(result, Is.Positive);
        
    }
    
    
    [Test]
    public void LinqSyntax()
    {

        var selectedAuthors = _book.Authors.Where(author => author.Contains("u"));
        Assert.That(selectedAuthors.Count, Is.EqualTo(2));

    }
    
}