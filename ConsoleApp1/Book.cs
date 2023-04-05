using System.Collections;

namespace ConsoleApp1;

public class Book 
{
    public List<string> Authors = new List<string>() {"Woody Woodpacker", "Duffy Duck", "Bucks Bunny"};

    private readonly string _name;
    private readonly string _uuid;

    private Hashtable _quotations = new Hashtable() {{1, "first quote"}, {2, "second quote"}, {3, "third quote"}};

    public Book(string name, string uuid = "123456")
    {
        _name = name;
        _uuid = uuid;
        
        
    }

    public override string ToString()
    {
        return _name + " " + _uuid;
    }
    
    
    // int length = await DownloadDescriptionAsync();
    public async Task<int> DownloadDescriptionAsync()
    {
        var httpClient = new HttpClient();
        int exampleInt = (await httpClient.GetStringAsync("http://msdn.microsoft.com")).Length;
        return exampleInt;
    }

    public string? GetQuoteNumber(int i)
    {
        return (string?) _quotations[i];
    }
}