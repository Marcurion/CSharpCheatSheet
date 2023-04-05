namespace ConsoleApp1;


public sealed class BookDatabase
{
        public static readonly BookDatabase Instance = new BookDatabase();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static BookDatabase()
        {
        }

        private BookDatabase()
        {
        }


        public System.Action<Book> NotifySubscribers;

        private Dictionary<Book, DateTime> _allBooks = new Dictionary<Book, DateTime>();

        private Stack<Book> _toAnnounced = new Stack<Book>();

        public void RegisterNewBook(Book book)
        {
                _allBooks.Add(book, DateTime.Now);
                _toAnnounced.Push(book);
                
        }

        public void AdvocateNewBooks()
        {
                Book latest;
                
                while(_toAnnounced.TryPop(out latest))
                {
                        NotifySubscribers?.Invoke(latest);
                }
        }
}