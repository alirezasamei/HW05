Repository person = new Repository();
person.Add(new Person("ali","saeedi",31,"0013982990","09102100915"));
person.Add(new Person("ali","saeedi",31,"0013982990","09102100915"));
person.Add(new Person("hamid","seyedi",41,"1234567890","09123456789"));
Console.WriteLine(DataStore.People[0]==DataStore.People[1]);