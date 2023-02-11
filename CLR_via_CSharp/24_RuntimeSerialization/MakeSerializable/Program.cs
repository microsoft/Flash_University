using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

Point p = new Point();
//p.x = 5;
p.y = 10;

//using (var stream = new MemoryStream())
//{
//#pragma warning disable SYSLIB0011
//    new BinaryFormatter().Serialize(stream, p);
//#pragma warning restore SYSLIB0011
//}




Console.WriteLine(JsonConvert.SerializeObject(p));

class Point
{
    private int x { get; set; } = 5;
    public int y { get; set; }
}
