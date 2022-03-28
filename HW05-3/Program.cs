List<Person> persons = new List<Person>();
foreach (string item in File.ReadAllLines(@"..\..\..\IO Data\data.csv").Skip(1))
    persons.Add(new Person(item));

var a = persons.Where(p => p.Age > 20).OrderBy(p => p.FName).ThenBy(p => p.LName);
File.WriteAllLines(@"..\..\..\IO Data\a.csv", a.Select(p => p.ToString()));

var b = persons.Where(p => p.BornDate.Year < 1999);
File.WriteAllLines(@"..\..\..\IO Data\b.csv", b.Select(p => p.ToString()));

var c = persons.GroupBy(p => p.BornDate.Year);
foreach (var group in c)
    File.AppendAllLines(@"..\..\..\IO Data\c.csv", group.Select(p => p.ToString()).Append(""));

var d = persons.OrderBy(p => p.Id).ElementAt(3);
File.WriteAllText(@"..\..\..\IO Data\d.csv", d.ToString());

var e = persons.OrderBy(p => p.Id).Skip(49).Take(31);
//var e =persons.OrderBy(p => p.Id).ToList().GetRange(49, 31);
File.WriteAllLines(@"..\..\..\IO Data\e.csv", e.Select(p => p.ToString()));

var f = persons.Where(p => p.Age == persons.Max(p => p.Age));
File.WriteAllLines(@"..\..\..\IO Data\f.csv", f.Select(p => p.ToString()));

var g = !(persons.GroupBy(p => p.NationalCode).Count() == persons.Count());
File.WriteAllText(@"..\..\..\IO Data\g.csv", "Is there any duplicated national code?  " + (g ? "Yes" : "No"));

var h = persons.Where(p => p.Address.Contains("Illinois"));
File.WriteAllLines(@"..\..\..\IO Data\h.csv", h.Select(p => p.ToString()));

var i = h.GroupBy(p => p.FName).Where(g => g.Count() > 1);
foreach (var group in i)
    File.AppendAllLines(@"..\..\..\IO Data\i.csv", group.Select(p => p.ToString()).Append(""));

var j = persons.Any(p => p.NationalCode == 123);
//var j = persons.Any(p => p.NationalCode.ToString().Contains("123"));
File.WriteAllText(@"..\..\..\IO Data\j.csv", "Is there anyone with \"123\" national code?  " + (j ? "Yes" : "No"));

var k = persons.Where(p => p.Age > 25).Select(p => new { p.NationalCode, p.Address });
File.WriteAllLines(@"..\..\..\IO Data\k.csv", k.Select(p=>p.NationalCode+", "+p.Address));
