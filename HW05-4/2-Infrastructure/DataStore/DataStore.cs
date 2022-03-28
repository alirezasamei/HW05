public static class DataStore
{
    public static List<Library> Libraries { get; set; }
    static DataStore()
    {
        Libraries = new List<Library>();
    }
}
