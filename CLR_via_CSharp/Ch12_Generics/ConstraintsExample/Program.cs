internal sealed class Atype
{
}

internal sealed class AType<T>
{
}

internal sealed class AType<T1, T2>
{
}


// 1 Constraints do not differentiate types
//internal sealed class AType<T> where T : IComparable<T>
//{
//}

internal sealed class AnotherType
{
    private static void M()
    {
    }

    private static void M<T>()
    {
    }
}