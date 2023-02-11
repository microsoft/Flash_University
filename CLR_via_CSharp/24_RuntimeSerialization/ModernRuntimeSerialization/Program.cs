// create a person

Person p = new Person();
p.FirstName = "Jeffrey";
p.LastName = "Richter";


// voila, see them in xml
System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(p.GetType());
x.Serialize(Console.Out, p);

Console.WriteLine();
Console.ReadLine();

public class Person
{
    public string FirstName;
    public string LastName;
}