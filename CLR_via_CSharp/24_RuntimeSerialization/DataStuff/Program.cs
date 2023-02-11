using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

Point p = new Point();

//p.x = 5;
//p.y = 10;



using (var stream = new MemoryStream())
{
#pragma warning disable SYSLIB0011
    new BinaryFormatter().Serialize(stream, p);
#pragma warning restore SYSLIB0011
}


// Console.WriteLine(JsonConvert.SerializeObject(p));


// Console.WriteLine(JsonConvert.SerializeObject(p));

//fix here
//datacontract, datamember, ignore
[Serializable]
class Point
{
    [DataMember] private int x { get; set; } = 5;
    [DataMember] private int y { get; set; } = 10;
}