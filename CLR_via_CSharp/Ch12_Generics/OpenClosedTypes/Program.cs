object o = null;

var t = typeof(Dictionary<,>);

o = CreateInstance(t);

t = typeof(DictionaryStringKey<Guid>);
o = CreateInstance(t);
var open = new Open<long, long>();


var closed = new Dictionary<string, int>();
Console.WriteLine("Object type =" + o.GetType());

static object CreateInstance(Type t)
{
    object o = null;
    try
    {
        o = Activator.CreateInstance(t);
        Console.WriteLine("Created instance of {0}", t);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }

    return 0;
}


// SO this guy is going to be a sealed class. It is a ___ type because of ?
internal sealed class DictionaryStringKey<TValue> : Dictionary<string, TValue>
{
}

internal sealed class Closed
{
}

internal sealed class Open<TKey, TValue> : Dictionary<TKey, TValue>
{
}