public class Member : Person
{
    public int MemberId { get; set; }
    public Member(string firstname, string lastName, int memberId) : base(firstname, lastName)
    {
        MemberId = memberId;
    }
    public void GetBorrowedBooks()
    {
        foreach (var librarybooks in DataStore.Libraries.Select(l => l.Books.Where(b => b.MemberBorrowed == this)))
            foreach (var book in librarybooks)
                Console.WriteLine(book);
    }
}