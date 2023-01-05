// INitial example from the book

using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

var objectGraph = new List<String>{"one", "two", "three"};
Stream stream = SerializeToMemory(objectGraph);

// Reset from 0

stream.Position = 0;
objectGraph = null;

objectGraph = (List<String>)DeserializeFromMemory(stream);
foreach (var s in objectGraph)
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