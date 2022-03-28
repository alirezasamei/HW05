public class Person
{
    public string Name { get; set; }
    public string Family { get; set; }
    public int Age { get; set; }
    public string NationalCode { get; set; }
    public string Mobile { get; set; }
    public Person(string name, string family, int age, string nationalCode, string mobile)
    {
        Name = name;
        Family = family;
        Age = age;
        NationalCode = nationalCode;
        Mobile = mobile;
    }
    public static bool operator ==(Person person1, Person person2) =>
        person1.Name==person2.Name && person1.Family==person2.Family && person1.Age==person2.Age && person1.NationalCode==person2.NationalCode && person1.Mobile==person2.Mobile;
    public static bool operator !=(Person person1, Person person2) => !(person1==person2);
}

