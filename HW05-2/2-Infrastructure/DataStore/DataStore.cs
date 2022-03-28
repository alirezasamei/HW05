public static class DataStore
{
    public static List<Person> People { get; set; }
    static DataStore() => People = new List<Person>();
}