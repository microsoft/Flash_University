SomeType.Test();

public static class SomeType
{
    public static void Test()
    {
        var x = 5;
        var g = new Guid();
        M(x);
        M(g);
    }

    // public static Int32 M<T>(T t) where T : IComparable, IConvertible
    //{
    //    Console.WriteLine("in method");
    //    return 0;
    //}
    public static int M<T>(T t) where T : struct
    {
        Console.WriteLine("in method");
        return 0;
    }
}