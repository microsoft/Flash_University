object o = null;

var t = typeof(Dictionary<,>);

o = CreateInstance(t);

t = typeof(DictionaryStringKey<Guid>);
o = CreateInstance(t);

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