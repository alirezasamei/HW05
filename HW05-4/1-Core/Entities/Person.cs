public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public String NationalCode { get; set; }
    public string Mobile { get; set; }
    public Person(string firstname, string lastName)
    {
        FirstName = firstname;
        LastName = lastName;
    }
}