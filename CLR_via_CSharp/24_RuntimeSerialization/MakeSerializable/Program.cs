using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

Point p = new Point();

//using (var stream = new MemoryStream())
//{
//#pragma warning disable SYSLIB0011
//    new BinaryFormatter().Serialize(stream, p);
//#pragma warning restore SYSLIB0011
//}


Console.WriteLine(JsonConvert.SerializeObject(p));

p.x = 5;
p.y = 10;


Console.WriteLine(JsonConvert.SerializeObject(p));

//fix here
class Point
{
    public int x { get; set; }
    public int y { get; set; }
}