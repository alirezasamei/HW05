public class Book
{
    public string Name { get; set; }
    public BookWriter Writer { get; set; }
    public bool Borrowed { get; set; }
    public Member? MemberBorrowed { get; set; }
    public LibraryDate LibraryDate { get; set; }
    public Book(string name, BookWriter writer)
    {
        Name = name;
        Writer = writer;
        Borrowed = false;
    }
    public void GetWriter()
    {
        Console.WriteLine(Writer);
    }
    public void GetMemberBorrowed()
    {
        Console.WriteLine(MemberBorrowed);
    }
    public override string ToString()
    {
        return Name + " , " + Writer + " : " + (Borrowed ? "Borrowed" : "Exists");
    }
}