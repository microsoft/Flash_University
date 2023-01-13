using System.Runtime.Serialization.Formatters.Binary;

var objectGraph = new ObjectWithEnums();
objectGraph.values.Add(NotAnEnum.a);
objectGraph.values.Add(NotAnEnum.b);
Stream stream = SerializeToMemory(objectGraph);

// Reset from 0

stream.Position = 0;
while (stream.Position < stream.Length)
{
    Console.WriteLine(stream.ReadByte());
}

// reset again
stream.Position = 0;
objectGraph = null;

objectGraph = (ObjectWithEnums)DeserializeFromMemory(stream);
foreach (var s in objectGraph.values)
{
    Console.WriteLine(s);
}

static MemoryStream SerializeToMemory(Object objectGraph)
{
    // create a stream w/ the objects
    MemoryStream stream = new MemoryStream();

    // Construct a serializer
    BinaryFormatter formatter = new BinaryFormatter();
    BinaryReader reader = new BinaryReader(stream);
    //reader.ReadBytes(objectGraph);
    // this is the outdated way of doing it
#pragma warning disable SYSLIB0011
    formatter.Serialize(stream, objectGraph);
#pragma warning restore SYSLIB0011

    return stream;
}

static Object DeserializeFromMemory(Stream stream)
{

    // Construct a serializer
    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning disable SYSLIB0011
    return formatter.Deserialize(stream);
#pragma warning restore SYSLIB0011
}

enum NotAnEnum
{
    a=0, b=1
}
[Serializable]
class ObjectWithEnums
{
    public List<NotAnEnum> values
    {
        get;
        set;
    } = new List<NotAnEnum>();
}