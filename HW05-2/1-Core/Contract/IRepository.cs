public interface IRepository
{
    public bool Add(Person person);
    public Person? Get(string nationalCode);
    public List<Person> GetAll();
    public bool Update(Person person);
    public bool Delete(string nationalCode);
}