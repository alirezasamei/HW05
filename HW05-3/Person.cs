public class Person
{
    public int Id { get; set; }
    public string FName { get; set; }
    public string LName { get; set; }
    public DateTime BornDate { get; set; }
    public int Age { get; set; }
    public long NationalCode { get; set; }
    public string Address { get; set; }
    public Person(int id, string fName, string lName, DateTime bornDate, long nationalCode, string address)
    {
        Id = id;
        FName = fName;
        LName = lName;
        BornDate = bornDate;
        Age = DateTime.Now.Year - BornDate.Year;
        NationalCode = nationalCode;
        Address = address;
    }

    public Person(string personCSV)
    {
        string[] prop = personCSV.Split(',');
        Id = Convert.ToInt32(prop[0]);
        FName = prop[1];
        LName = prop[2];
        BornDate = Convert.ToDateTime(prop[3]);
        Age = DateTime.Now.Year - BornDate.Year;
        NationalCode = Convert.ToInt64(prop[4]);
        Address = prop[5];
    }
    public override string ToString()
    {
        return $"{Id}, {FName} {LName}, Age:, {Age}, National code:, {NationalCode}, Address:, {Address}";
    }
}