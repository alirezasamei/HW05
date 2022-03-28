public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }


    public Library(string name)
    {
        Name = name;
    }
    public void AddBook(Book book)=> Books.Add(book);
    public void DeleteBook(Book book)=> Books.Remove(book);
    public void AddBorrowedBook(Book borrowedBook,Member member,LibraryDate borrowedDate)
    {

    }
    public void DeleteBorrowedBook(Book borrowedBook, LibraryDate borrowedBackDate)
    {

    }
    public void GetBooks()
    {
        foreach(var book in Books)
            Console.WriteLine(book);
    }
    public void GetBorrowedBooks()
    {
        foreach(var book in Books.Where(b => b.Borrowed).OrderBy(b => b.LibraryDate.BorrowDate))
            Console.WriteLine(book);
    }
    public void GetAvailableBooks()
    {
        foreach (var book in Books.Where(b => !b.Borrowed))
            Console.WriteLine(book);
    }
    public void AddLibrarian(Librarian librarian)
    {

    }
}
