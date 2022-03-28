public class Repository : IRepository
{
    public bool Add(Person person)
    {
        try
        {
            DataStore.People.Add(person);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool Delete(string nationalCode)
    {
        try
        {
            DataStore.People.Remove(Get(nationalCode));
            return true;
        }
        catch
        {
            return false;
        }
    }

    public Person? Get(string nationalCode)
    {
        return DataStore.People.FirstOrDefault(p => p.NationalCode == nationalCode);
    }

    public List<Person> GetAll()
    {
        return DataStore.People.ToList();
    }

    public bool Update(Person person)
    {
        try
        {
            DataStore.People[DataStore.People.FindIndex(p => p.NationalCode == person.NationalCode)]=person;
            return true;
        }
        catch
        {
            return false;
        }
    }
}