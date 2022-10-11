using Session_7.Examples;

var e = new Employee("Joe", "Acme Corp", "Safety Inspectors", new Job("inspect dynamite"));

Console.WriteLine(e + "\n");

e.ChangeJob(new Job("examine anvils"));
e.SetSpouse(new Person("Jill"));
e.Children.Add(new Person("Jane"));

Console.WriteLine(e);
